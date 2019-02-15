using Models.Entity;

namespace Service.Contracts
{
    public interface IPlayerService
    {
        Player Insert(Player player);
    }
}