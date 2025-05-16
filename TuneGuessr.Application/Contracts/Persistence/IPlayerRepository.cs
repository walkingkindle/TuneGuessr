using TuneGuessr.Domain.Entities;

namespace TuneGuessr.Application.Contracts.Persistence
{
    public interface IPlayerRepository : IAsyncRepository<Player>
    {
        int GetPlayerCount();

    }
}
