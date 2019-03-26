using System.Linq;
using DataProvider.Contracts;
using Models.Entity;

namespace Data.PlayersLooking
{
    public class Insert : IQuery<PlayerLooking>
    {
        private readonly PlayerLooking _playerLooking;

        public Insert(PlayerLooking playerLooking)
        {
            _playerLooking = playerLooking;
        }

        PlayerLooking IQuery<PlayerLooking>.Execute(ICommandQuery commandQuery)
        {
            var sql = @"Insert into PlayersLooking (FirstName, LastName, Age, Gender, Email, Phone, EventNeedingPartner, DoublesRating, MixedRating) 
                        values (@FirstName, @LastName, @Age, @Gender, @Email, @Phone, @EventNeedingPartner, @DoublesRating, @MixedRating);
                        select cast(scope_identity() as int)";
            _playerLooking.Id = commandQuery.Query<int>(sql, _playerLooking).First();
            return _playerLooking;
        }
    }
}