using System.Collections.Generic;
using Models.Entity;

namespace Service.Contracts
{
    public interface IRatingService
    {
        IEnumerable<Rating> Get();
    }
}