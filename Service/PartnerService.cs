using Data.Partners;
using DataProvider.Contracts;
using Models.Entity;
using Service.Contracts;

namespace Service
{
    public class PartnerService : IPartnerService
    {
        private readonly IDatabase _database;

        public PartnerService(IDatabase database)
        {
            _database = database;
        }

        public Partner Insert(Partner partner)
        {
            return _database.Query(new Insert(partner));
        }
    }
}