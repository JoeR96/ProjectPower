

using ProjectPower.Factories.ExerciseListFactory.Abstract;
using ProjectPower.Factories.ExerciseListFactory.ConcreteFactory;
using ProjectPower.Factory.Concrete_Classes;


namespace ProjectPower.Factory
{
    class ChestFactory : WorkoutFactory
    {
        private WorkoutExerciseListFactory Factory = null;
        private int _currentWave;
        private int _currentWaveIndex;
        private ExerciseList _exerciseList;

        public ChestFactory(int currentWave, int currentWaveIndex, ExerciseList e)
        {
            Factory = new WorkoutExerciseListFactory(e.T1, e.T2, e.T3A, e.T3B, e.T4A, e.T4B);

            _currentWave = currentWave;
            _currentWaveIndex = currentWaveIndex;
            _exerciseList = e;
        }

        public override Workout GetWorkout()
        {
            return new Chest(_currentWave, _currentWaveIndex, _exerciseList);
        }
    }
}
