using System.Collections.Generic;
using Facade.Contracts;
using Models.Entity;
using Service.Contracts;

namespace Facade
{
    public class PlayerLookingFacade : IPlayerLookingFacade
    {
        private readonly IPlayerLookingService _playerLookingService;

        public PlayerLookingFacade(IPlayerLookingService playerLookingService)
        {
            _playerLookingService = playerLookingService;
        }

        public IEnumerable<PlayerLooking> GetPlayersLookingForPartner()
        {
            return _playerLookingService.GetPlayersLookingForPartner(); 
        }

        public PlayerLooking AddPlayer(PlayerLooking playerLooking)
        {
            return _playerLookingService.Insert(playerLooking);
        }
    }
}