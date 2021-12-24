using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProjectPowerData.Folder.Models
{
    public abstract class BasicWorkoutInformation : IBasicWorkoutInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [Required]
        public virtual string Category { get; set; }
        [Required]
        public virtual int ExerciseDay { get; set; }
        [Required]
        public virtual int ExerciseOrder { get; set; }
        [Required]
        public virtual string Template { get; set;  }
        [Required]
        public virtual string UniqueId { get; set; }
        [Required]
        public virtual string UserName { get; set; }
        public BasicWorkoutInformation() { }

    }

    public interface IBasicWorkoutInformation
    {
        BasicWorkoutInformation BasicWorkoutInformation;
    }
}
