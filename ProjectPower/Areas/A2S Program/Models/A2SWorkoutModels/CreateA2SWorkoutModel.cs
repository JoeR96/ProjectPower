using ProjectPower.Areas.ExerciseCreation.Models;
using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class CreateA2SWorkoutModel : CreateExerciseModel
    {
   
        [Required]
        public decimal TrainingMax { get; set; }
        [Required]
        public bool AuxillaryLift { get; set; }    
        
        public int AmrapRepTarget { get; set; }                                                                                                                                                                                                                                                                                                            public decimal Intensity { get; set; }
        public int Sets { get; set; }                                                                          

    }
}
