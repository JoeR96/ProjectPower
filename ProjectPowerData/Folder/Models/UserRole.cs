using System.ComponentModel.DataAnnotations.Schema;


namespace ProjectPowerData.Folder.Models
{
    [Table("UserRoles")]
    public class UserRole
    {
        public int UserId { get; set; }
        public User UserAccount { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
