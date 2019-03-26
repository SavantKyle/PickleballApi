using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Facade.Contracts;
using Models.Entity;
using NLog;

namespace pickleballApi.Controllers
{
    [RoutePrefix("api/PlayerLooking")]
    public class PlayerLookingController : ApiController
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly IPlayerLookingFacade _playerLookingFacade;

        public PlayerLookingController(IPlayerLookingFacade playerLookingFacade)
        {
            _playerLookingFacade = playerLookingFacade;
        }

        [HttpGet, Route("GetPlayers")]
        public IHttpActionResult GetPlayers()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            var playersLooking = _playerLookingFacade.GetPlayersLookingForPartner(); 
            
            return Ok(playersLooking);
        }

        [HttpPost, Route("AddPlayer")]
        public IHttpActionResult AddPlayer([FromBody] PlayerLooking playerLooking)
        {
            try
            {
                _playerLookingFacade.AddPlayer(playerLooking);
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.StackTrace);
                throw;
            }
            return Ok(); 
        }
    }
}