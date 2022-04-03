using System.Threading.Tasks;

namespace ProjectPower.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();

    }
}
