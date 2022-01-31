using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class A2SWorkoutValuesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool AuxillaryLift { get; set; }
        [Required]
        public string Block { get; set; }
        [Required]
        public int AmrapRepTarget { get; set; }
        [Required]
        public int Week { get; set; }
        [Required]
        public decimal Intensity { get; set; }
        [Required]
        public int Sets { get; set; }
        [Required]
        public int RepsPerSet { get; set; }
        [Required]
        public decimal BeatByOne { get; set; }
        [Required]
        public decimal BeatByTwo { get; set; }
        [Required]
        public decimal BeatByThree { get; set; }
        [Required]
        public decimal BeatByFour { get; set; }
        [Required]
        public decimal BeatByFive { get; set; }
        public decimal MatchedTarget { get; set; }
        [Required]
        public decimal UnderByOne { get; set; }
        [Required]
        public decimal UnderByTwo { get; set; }


    }
}
