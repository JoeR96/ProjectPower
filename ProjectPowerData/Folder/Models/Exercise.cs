﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class Exercise
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [Required]
        public virtual string Category { get; set; }
        [Required]
        public virtual int ExerciseDay { get; set; }
        [Required]
        public virtual int ExerciseOrder { get; set; }
        [Required]
        public virtual string Template { get; set; }
        [Required]
        public virtual string UserName { get; set; }
        [Required]
        public int Week { get; set; }
        [Required]
        public string ExerciseMasterId { get; set; }
        public bool? ExerciseCompleted { get; set; }
        public bool? ExerciseTargetCompleted { get; set; }

        public Exercise() { }

    }


}
