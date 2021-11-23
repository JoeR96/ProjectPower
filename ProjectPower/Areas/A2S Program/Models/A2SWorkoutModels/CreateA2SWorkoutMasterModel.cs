using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class CreateA2SWorkoutMasterModel
    {

        public List<A2SExerciseDaysAndOrders>?ExerciseDaysAndOrders { get; set; }

    }

    public class A2SExerciseDaysAndOrders
    {
        //Only need to return the Id, we can use the array index for both day and order

        public List<CreateA2SWorkoutModel> exercises { get; set; }
    }

 
}
