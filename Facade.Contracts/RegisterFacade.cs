using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Domain;

namespace Facade.Contracts
{
    public interface IRegisterFacade
    {
        void RegisterPlayer(PlayerInfo playerInfo);
    }
}
