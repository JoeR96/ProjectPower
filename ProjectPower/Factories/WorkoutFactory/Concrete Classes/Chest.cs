using ProjectPower.Factories.ExerciseListFactory.Abstract;
using ProjectPower.Models;


namespace ProjectPower.Factory.Concrete_Classes
{
    class Chest : Workout
    {
        private readonly string _workoutName;
        private int _currentWave;
        private int _currentWaveIndex;
        private ExerciseList _exerciseList;
        public Chest(int currentWave, int currentWaveIndex, ExerciseList exerciseList)
        {
            _workoutName = "Chest";
            _currentWave = currentWave;
            _currentWaveIndex = currentWaveIndex;
            _exerciseList = exerciseList;
        }


        public override string WorkoutName
        {
            get { return _workoutName; }
        }

        public override int CurrentWave
        {
            get { return _currentWave; }
            set { _currentWave = value; }
        }

        public override int CurrentWaveIndex
        {
            get { return _currentWaveIndex; }
            set { _currentWaveIndex = value; }
        }

        public override ExerciseList ExerciseList
        {
            get { return _exerciseList; }
            set { _exerciseList = value; }
        }
    }
}
