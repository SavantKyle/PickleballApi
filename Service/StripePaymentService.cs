using System;
using System.Collections.Generic;
using Models.Domain;
using Service.Contracts;
using Stripe;

namespace Service
{
    public class StripePaymentService : IStripePaymentService
    {
        public Charge Charge(StripePaymentRequest stripePaymentRequest)
        {
            var myCharge = new ChargeCreateOptions()
            {
                Amount = stripePaymentRequest.Amount * 100,
                Currency = "usd",
                SourceId = stripePaymentRequest.TokenId,
                StatementDescriptor = "Crawfish Cup Pickle...", 
                ReceiptEmail = stripePaymentRequest.ReceiptEmail,
                Description = stripePaymentRequest.Description,
                Metadata = new Dictionary<string, string>() 
            };
            myCharge.Metadata["OurRef"] = "OurRef-" + Guid.NewGuid();

            try
            {
                return new ChargeService().Create(myCharge);
            }
            catch (StripeException ex)
            {
                throw new Exception(ex.StripeError.Message);
            }
        }
    }
}
