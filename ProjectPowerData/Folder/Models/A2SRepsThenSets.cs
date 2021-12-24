using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class A2SRepsThenSets : BasicWorkoutInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
      
        [Required]
        public int StartingReps { get; set; }
        [Required]
        public int StartingSets { get; set; }
        [Required]
        public int RepIncreasePerSet { get; set; }
        [Required]
        public int GoalSets { get; set; }
        [Required]
        public int GoalReps { get; set; }
        [Required]
        public decimal StartingWeight { get; set; }
        [Required]
        public int Week { get; set;}
        [NotMapped]
        public override string Name { get; set; }
        [NotMapped]
        public override string Category { get; set; }
        [NotMapped]
        public override int ExerciseDay { get; set; }
        [NotMapped]
        public override int ExerciseOrder { get; set; }
        [NotMapped]
        public override string Template { get; set; }
        [NotMapped]
        public override string UserName { get; set; }
        public A2SRepsThenSets(){}
    }
}
