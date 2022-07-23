using GameStore.Domain.Base;

namespace GameStore.Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameDbContext context;

        public UnitOfWork(GameDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
