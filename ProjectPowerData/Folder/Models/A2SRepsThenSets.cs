using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class A2SRepsThenSets : BasicWorkoutInformation
    {
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
        public A2SRepsThenSets()
        {}
    }
}
