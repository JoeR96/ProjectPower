﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class UserAccounts : IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [PersonalData]
        [EmailAddress]
        public string Email { get; set; }
        public int CurrentWeek { get; set; }
        public int CurrentDay { get; set; }
        public int WorkoutDaysInWeek { get; set; }
        public int WorkoutWeeks { get; set; }

        public UserAccounts() { }
    }
}
