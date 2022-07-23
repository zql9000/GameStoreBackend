namespace GameStore.Domain.Base
{
    public interface IRepository<TEntity>
        where TEntity : BaseModel
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity? GetById(int id);
        IQueryable<TEntity> GetEntities();
    }
}
