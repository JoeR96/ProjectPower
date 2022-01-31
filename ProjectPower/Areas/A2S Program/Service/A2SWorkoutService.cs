using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPowerData;

namespace ProjectPower.Areas.A2S_Program.Service
{
    public class A2SWorkoutService : IA2SWorkoutService
    {
        private readonly DataContext _dc;
        public A2SWorkoutService(DataContext context)
        {
            _dc = context;
        }

        public void Delete(long id)
        {
            _dc.SaveChanges();
        }


    }
}
