using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerDAL.Folder.Models
{
    class WorkoutExerciseInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public int Reps { get; set; }
        public int Sets { get; set; }
        public WorkoutExerciseInformation() { }
    }
}
