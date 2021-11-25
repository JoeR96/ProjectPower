using ProjectPower.Areas.ExerciseCreation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.A2SRepsThenSetsIncreaModels
{
    public class CreateA2SRepsThenSetsModel : CreateExerciseModel
    {
        public int StartingReps { get; set; }
        public int StartingSets { get; set; }
        public int RepIncrease { get; set; }

    }
}
