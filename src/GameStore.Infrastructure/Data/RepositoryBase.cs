using GameStore.Domain.Base;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Infrastructure.Data
{
    public abstract class RepositoryBase<TEntity> : IRepository<TEntity>
        where TEntity : BaseModel
    {
        protected RepositoryBase(GameDbContext gameDbContext)
            => _gameDbContext = gameDbContext;

        private readonly GameDbContext _gameDbContext;

        protected DbSet<TEntity> Entities => _gameDbContext.Set<TEntity>();

        public virtual void Add(TEntity entity)
            => Entities.Add(entity);

        public virtual void AddRange(IEnumerable<TEntity> entities)
            => Entities.AddRange(entities);

        public virtual void Update(TEntity entity)
            => Entities.Update(entity);

        public virtual void Delete(TEntity entity)
            => Entities.Remove(entity);

        public virtual TEntity? GetById(int id)
            => GetEntities().FirstOrDefault(e => e.Id == id);

        public virtual IQueryable<TEntity> GetEntities()
            => Entities;
    }
}
