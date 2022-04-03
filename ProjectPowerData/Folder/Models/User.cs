using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class User 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(255)]
        public string Email { get; set; }
        public int CurrentWeek { get; set; }
        public int CurrentDay { get; set; }
        public int WorkoutDaysInWeek { get; set; }
        public int WorkoutWeeks { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new Collection<UserRole>();


        public User() { }
    }
}
