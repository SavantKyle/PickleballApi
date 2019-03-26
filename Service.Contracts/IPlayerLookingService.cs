using System.Collections.Generic;
using Models.Entity;

namespace Service.Contracts
{
    public interface IPlayerLookingService
    {
        IEnumerable<PlayerLooking> GetPlayersLookingForPartner();
        PlayerLooking Insert(PlayerLooking playerLooking);
    }
}