using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Facade.Contracts;
using Models.Domain;
using NLog;
using Service.Contracts;

namespace pickleballApi.Controllers
{
    [RoutePrefix("api/Register")]
    public class RegisterController : ApiController
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IRegisterFacade _registerFacade;
        private readonly IStripePaymentService _stripePaymentService;

        public RegisterController(IRegisterFacade registerFacade, IStripePaymentService stripePaymentService)
        {
            _registerFacade = registerFacade;
            _stripePaymentService = stripePaymentService;
        }

        public RegisterController()
        {
            
        }

        [HttpGet, Route("TestCharge")]
        public IHttpActionResult TestCharge()
        {
            var payment = new PlayerAndPaymentInfo()
            {
                StripePaymentRequest = new StripePaymentRequest()
                {
                    Amount = 65, 
                    Description = "Crawfish Cup Pickleball Test Charge", 
                    ReceiptEmail = "kyle.savant@batonrougepickleball.com"
                }
            };

            _stripePaymentService.Charge(payment.StripePaymentRequest); 
            return Ok();
        }

        [HttpPost, Route("RegisterPlayer")]
        public IHttpActionResult RegisterPlayer([FromBody] PlayerAndPaymentInfo playerAndPaymentInfo)
        {
            try
            {
                _stripePaymentService.Charge(playerAndPaymentInfo.StripePaymentRequest);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
                throw new HttpResponseException(
                    new HttpResponseMessage(HttpStatusCode.PaymentRequired)
                    {
                        StatusCode = HttpStatusCode.InternalServerError,
                        ReasonPhrase = ex.Message
                    });
            }

            _registerFacade.RegisterPlayer(playerAndPaymentInfo.PlayerInfo);

            return Ok();
        }
    }
}