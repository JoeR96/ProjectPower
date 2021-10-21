using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class A2SDailyWorkoutModel
        
    {
        public string ExerciseName { get; set; }
        public decimal WorkingWeight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public int AmrapTarget { get; set; }
        public decimal RoundingValue { get; set; }
        public int Id { get; set; }
    }
}
