using System.Collections.Generic;
using DataProvider.Contracts;
using Models.Entity;

namespace Data.PlayersLooking
{
    public class GetAll : IQuery<IEnumerable<PlayerLooking>>
    {
        public IEnumerable<PlayerLooking> Execute(ICommandQuery commandQuery)
        {
            return commandQuery.Query<PlayerLooking>("select * from PlayersLooking");
        }
    }
}