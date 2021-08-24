
using ProjectPower.Factories.ExerciseListFactory.Abstract;
using ProjectPower.Models;
using ProjectPower.Utility;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Factories.ExerciseListFactory.ConcreteClasses
{
    class WorkoutExerciseList : ExerciseList
    {
        private Exercise _t1;
        private Exercise _t2;
        private Exercise _t3A;
        private Exercise _t3B;
        private Exercise _t4A;
        private Exercise _t4B;

        public WorkoutExerciseList(Exercise t1, Exercise t2, Exercise t3A, Exercise t3B, Exercise t4A, Exercise t4B)
        {
            _t1 = t1;
            _t2 = t2;
            _t3A = t3A;
            _t3B = t3B;
            _t4A = t4A;
            _t4B = t4B;
        }


        public override Exercise T1 
        {
            get { return _t1;  }
            set { _t1 = value; }
        }

        public override Exercise T2
        {
            get { return _t2; }
            set { _t2 = value; }
        }

        public override Exercise T3A
        {
            get { return _t3A; }
            set { _t3A = value; }
        }

        public override Exercise T3B
        {
            get { return _t3B; }
            set { _t3B = value; }
        }

        public override Exercise T4A
        {
            get { return _t4A; }
            set { _t4A = value; }
        }

        public override Exercise T4B
        {
            get { return _t4B; }
            set { _t4B = value; }
        }


    }
}

