using Models.Domain;
using Models.Entity;
using Models.Enum;
using Service.Contracts.Mappers;

namespace Service.Mappers
{
    public class PartnerMapper : IPartnerMapper
    {
        public Partner MapMixedPartner(PlayerInfo playerInfo)
        {
            return new Partner()
            {
                FirstName = playerInfo.MixedPartnerFirstName,
                LastName = playerInfo.MixedPartnerLastName,
                Phone = playerInfo.MixedPartnerPhone, 
                
            };
        }

        public Partner MapDoublesPartner(PlayerInfo playerInfo)
        {
            return new Partner()
            {
                FirstName = playerInfo.DoublesPartnerFirstName,
                LastName = playerInfo.DoublesPartnerLastName,
                Phone = playerInfo.DoublesPartnerPhone
            };
        }
    }
}