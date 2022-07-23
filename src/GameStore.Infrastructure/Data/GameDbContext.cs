using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
        {

        }

        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Purchase> Purchases  => Set<Purchase>();
        public DbSet<Developer> Developers  => Set<Developer>();
        public DbSet<Customer> Customers  => Set<Customer>();
        public DbSet<Country> Countries  => Set<Country>();
    }
}
