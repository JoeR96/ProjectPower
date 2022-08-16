namespace ProjectPower.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();

    }
}
