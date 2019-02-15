using System.Linq;
using DataProvider.Contracts;
using Models.Entity;

namespace Data.Players
{
    public class Insert : IQuery<Player>
    {
        private readonly Player _player;

        public Insert(Player player)
        {
            _player = player;
        }

        Player IQuery<Player>.Execute(ICommandQuery commandQuery)
        {
            var sql = @"Insert into Players (FirstName, LastName, BirthYear, Gender, Email, Phone, EventsPlaying, DoublesRatingId, MixedRatingId, DoublesPartnerId, MixedPartnerId) 
                        values (@FirstName, @LastName, @BirthYear, @Gender, @Email, @Phone, @EventsPlaying, @DoublesRatingId, @MixedRatingId, @DoublesPartnerId, @MixedPartnerId);
                        select cast(scope_identity() as int)";
            _player.Id = commandQuery.Query<int>(sql, _player).First();
            return _player;
        }
    }
}