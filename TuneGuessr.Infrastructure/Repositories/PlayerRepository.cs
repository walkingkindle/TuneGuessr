using TuneGuessr.Application.Contracts.Persistence;
using TuneGuessr.Domain.Entities;

namespace TuneGuessr.Infrastructure.Repositories
{
    public class PlayerRepository : BaseRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(TuneGuessrDbContext dbContext) : base(dbContext)
        {
        }


        public int GetPlayerCount()
        {
            return _dbContext.Players.Count();
        }
    }
}
