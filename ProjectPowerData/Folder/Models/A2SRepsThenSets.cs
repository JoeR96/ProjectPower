using System.ComponentModel.DataAnnotations;

namespace ProjectPowerData.Folder.Models
{
    public class A2SRepsThenSets
    {
        [Required]
        public string UniqueId { get; set; }
        [Required]
        public int StartingReps { get; set; }
        [Required]
        public int StartingSets { get; set; }
        [Required]
        public int RepIncreasePerSet { get; set; }
    }
}
