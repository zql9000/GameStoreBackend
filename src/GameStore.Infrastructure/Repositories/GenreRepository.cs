using GameStore.Domain.Entities;
using GameStore.Domain.Repositories;
using GameStore.Infrastructure.Data;

namespace GameStore.Infrastructure.Repositories
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(GameDbContext gameDbContext) : base(gameDbContext)
        {
        }
    }
}
