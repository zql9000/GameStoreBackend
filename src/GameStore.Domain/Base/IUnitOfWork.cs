namespace GameStore.Domain.Base
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
