using Microsoft.EntityFrameworkCore;
using TuneGuessr.Domain.Entities;

namespace TuneGuessr.Infrastructure
{
    public class TuneGuessrDbContext : DbContext
    {
        public TuneGuessrDbContext(DbContextOptions<TuneGuessrDbContext> options):base(options)
        { }


        public DbSet<GameSession> GameSessions { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Round> Rounds { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Lobby> Lobbies { get; set; }

        public DbSet<PlayerState> PlayerStates { get; set; }

        public DbSet<Playlist> Playlists { get; set; }
        

    }
}
