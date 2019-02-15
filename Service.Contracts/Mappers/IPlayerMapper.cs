using System.Collections.Generic;
using Models.Domain;
using Models.Entity;

namespace Service.Contracts.Mappers
{
    public interface IPlayerMapper
    {
        Player Map(PlayerInfo playerInfo, IEnumerable<Rating> ratings, int? doublesPartnerId, int? mixedPartnerId); 
    }
}