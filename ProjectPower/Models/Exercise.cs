
using ProjectPower.Singleton;

namespace ProjectPower.Models
{
    class Exercise
    {
        string name;
        Utility.Enums.TargetGroup tier;
        int? max;
        decimal weight;
        int reps;
        string exerciseValues;

        public Exercise()
        {
            weight = Formula.Formula.WaveOneTierOne();
            reps = GlobalLiftInfo.WeekOneTierOneRepsPerSet;
            exerciseValues = ConcatenateExerciseWeightAndReps();
        }

        private string ConcatenateExerciseWeightAndReps()
        {
            return  weight + " x " + reps;
        }
    }
}
