using System.Collections.Generic;
using Data.PlayersLooking;
using DataProvider.Contracts;
using Models.Entity;
using Service.Contracts;

namespace Service
{
    public class PlayerLookingService : IPlayerLookingService
    {
        private readonly IDatabase _database;

        public PlayerLookingService(IDatabase database)
        {
            _database = database;
        }

        public IEnumerable<PlayerLooking> GetPlayersLookingForPartner()
        {
            return _database.Query(new GetAll());
        }

        public PlayerLooking Insert(PlayerLooking playerLooking)
        {
            return _database.Query(new Insert(playerLooking));
        }
    }
}