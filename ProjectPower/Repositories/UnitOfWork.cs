using ProjectPower.Repositories.Interfaces;
using ProjectPowerData;
using System.Threading.Tasks;

namespace ProjectPower.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dc;

        public UnitOfWork(DataContext dc)
        {
            _dc = dc;
        }

        public async Task CompleteAsync()
        {
            await _dc.SaveChangesAsync();
        }
    }
}
