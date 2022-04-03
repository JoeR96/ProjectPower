using System.ComponentModel.DataAnnotations;

namespace ProjectPowerData.Folder.Models
{
    public class A2SSetsThenReps :                                      Exercise
    {
        [Required]
        public int StartingReps { get; set; }
        [Required]
        public int StartingSets { get; set; }
        [Required]
        public int RepIncreasePerSet { get; set; }
        [Required]
        public int CurrentReps { get; set; }
        [Required]
        public int CurrentSets { get; set; }
        [Required]
        public int GoalSets { get; set; }
        [Required]
        public int GoalReps { get; set; }
        [Required]
        public decimal StartingWeight { get; set; }
        public A2SSetsThenReps()
        { }
    }
}
