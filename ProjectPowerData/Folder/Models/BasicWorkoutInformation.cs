using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class BasicWorkoutInformation
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int ExerciseDay { get; set; }
        [Required]
        public int ExerciseOrder { get; set; }
        [Required]
        public string UniqueId { get; set; }

        public BasicWorkoutInformation() { }
    }
}
