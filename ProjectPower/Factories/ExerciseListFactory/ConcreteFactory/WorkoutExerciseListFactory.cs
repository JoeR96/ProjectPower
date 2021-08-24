
using ProjectPower.Factories.ExerciseListFactory.Abstract;
using ProjectPower.Factories.ExerciseListFactory.ConcreteClasses;
using ProjectPower.Models;
using ProjectPower.Utility;
using System.Collections.Generic;

namespace ProjectPower.Factories.ExerciseListFactory.ConcreteFactory
{
    class WorkoutExerciseListFactory : ExerciseListAbstractFactory
    {
        private Exercise _t1;
        private Exercise _t2;
        private Exercise _t3A;
        private Exercise _t3B;
        private Exercise _t4A;
        private Exercise _t4B;

        public WorkoutExerciseListFactory(Exercise t1, Exercise t2, Exercise t3A, Exercise t3B, Exercise t4A, Exercise t4B)
        {
            _t1 = t1;
            _t2 = t2;
            _t3A = t3A;
            _t3B = t3B;
            _t4A = t4A;
            _t4B = t4B;
        }

        public override WorkoutExerciseList CreateExerciseList()
        {
            return new WorkoutExerciseList(_t1, _t2, _t3A, _t3B, _t4A, _t4B);
        }
    }
}

