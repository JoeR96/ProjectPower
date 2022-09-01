using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.LinearProgression.Models
{
    internal class LinearProgressionExercise : Exercise
    {
        public int MinimumReps { get; set; }
        public int MaximumReps { get; set; }
        public int TargetSets { get; set; }
        public int WeightIndex { get; set; }
        public bool PrimaryExercise { get; set; } = false;
        public decimal WorkingWeight { get; set; }
        public decimal WeightProgression { get; set; }
        public int AttemptsBeforeDeload { get; internal set; }
        public int CurrentAttempt { get; internal set; }
    }
}
