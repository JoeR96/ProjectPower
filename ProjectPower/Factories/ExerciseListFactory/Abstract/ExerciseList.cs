using ProjectPower.Models;
using ProjectPower.Utility;
using System.Collections.Generic;

namespace ProjectPower.Factories.ExerciseListFactory.Abstract
{
     abstract class ExerciseList
    {
        public abstract Exercise T1 { get; set; }
        public abstract Exercise T2 { get; set; }
        public abstract Exercise T3A { get; set; }
        public abstract Exercise T3B { get; set; }
        public abstract Exercise T4A { get; set; }
        public abstract Exercise T4B { get; set; }
    }
}
