using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.LinearProgression.Models
{
    internal class LinearProgressionWorkout
    {
        public int Sets { get; internal set; }
        public int Reps { get; internal set; }
        public List<int> setsAndReps { get; internal set; }
    }
}
