using ProjectPower.Factories.ExerciseListFactory.Abstract;
using ProjectPower.Models;


namespace ProjectPower.Factory
{
    abstract class Workout
    {
        public abstract string WorkoutName { get; }
        public abstract ExerciseList ExerciseList { get; set; }
        public abstract int CurrentWave { get; set; }
        public abstract int CurrentWaveIndex { get; set; }
    }
}
