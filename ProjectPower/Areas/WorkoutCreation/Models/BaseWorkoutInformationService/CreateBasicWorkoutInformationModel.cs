using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.A2S_Program.Models.BaseWorkoutInformationService
{
    public class CreateBasicWorkoutInformationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
