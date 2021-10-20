using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class GetA2SWeeklyWorkout
    {
        public string Username { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }

        public GetA2SWeeklyWorkout()
        {

        }
    }
}
