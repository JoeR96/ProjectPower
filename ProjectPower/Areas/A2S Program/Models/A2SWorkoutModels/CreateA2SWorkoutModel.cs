using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels
{
    public class CreateA2SWorkoutModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public decimal TrainingMax { get; set; }
        [Required]
        public bool AuxillaryLift { get; set; }    
        public string Block { get; set; }      
        public int AmrapRepTarget { get; set; }
        public int? AmrapRepResult { get; set; }
        public int Week { get; set; }
        public decimal Intensity { get; set; }
        public int Sets { get; set; }
        public int RepsPerSet { get; set; }
        
       
    }
}
