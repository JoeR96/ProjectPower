
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class UpdateA2SExerciseDayAndLiftOrderModel
    {

        public List<exerciseDaysAndOrders> ExerciseDaysAndOrders { get; set; }

    }

    public class exerciseDaysAndOrders
    {
        //Only need to return the Id, we can use the array index for both day and order

        public List<Exercise> exercises { get; set; }
    }

    public class Exercise
    {
   
        public string uniqueId { get; set; }
        public string exerciseName { get; set; }
    }
}
