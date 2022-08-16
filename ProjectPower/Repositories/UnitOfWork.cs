using ProjectPower.Repositories.Interfaces;
using ProjectPowerData;

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
