using Models.Domain;
using Models.Entity;

namespace Service.Contracts.Mappers
{
    public interface IPartnerMapper
    {
        Partner MapMixedPartner(PlayerInfo playerInfo);
        Partner MapDoublesPartner(PlayerInfo playerInfo);
    }
}