using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectPowerData.Folder.Models
{
    public class UserAccounts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password  { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int CurrentWeek { get; set; }
        public int CurrentDay { get; set; }
        public UserAccounts() { }
    }
}
