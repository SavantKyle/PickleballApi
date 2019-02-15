using Data.Players;
using DataProvider.Contracts;
using Models.Entity;
using Service.Contracts;

namespace Service
{
    public class PlayerService : IPlayerService
    {
        private readonly IDatabase _database;

        public PlayerService(IDatabase database)
        {
            _database = database;
        }

        public Player Insert(Player player)
        {
            return _database.Query(new Insert(player));
        }
    }
}