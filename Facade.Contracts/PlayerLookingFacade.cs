using System.Collections;
using System.Collections.Generic;
using Models.Entity;

namespace Facade.Contracts
{
    public interface IPlayerLookingFacade
    {
        IEnumerable<PlayerLooking> GetPlayersLookingForPartner();
        PlayerLooking AddPlayer(PlayerLooking playerLooking);
    }
}