using ProjectPower.Models;
using ProjectPower.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Factories.ExerciseListFactory.Abstract
{
    abstract class ExerciseListAbstractFactory
    {
        public abstract ExerciseList CreateExerciseList();
        
    }
}
