using System.Linq;
using DataProvider.Contracts;
using Partner = Models.Entity.Partner;

namespace Data.Partners
{
    public class Insert : IQuery<Partner>
    {
        private readonly Partner _partner;

        public Insert(Partner partner)
        {
            _partner = partner;
        }

        Partner IQuery<Partner>.Execute(ICommandQuery commandQuery)
        {
            var sql = @"Insert into Partners (FirstName, LastName, Phone) values (@FirstName, @LastName, @Phone);
                        select cast(scope_identity() as int)";
            _partner.Id = commandQuery.Query<int>(sql, _partner).First();
            return _partner;
        }
    }
}
