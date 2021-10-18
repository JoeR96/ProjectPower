using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.UserAccounts.Models.UserAccounts
{
    public class ShowUserAccountModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int CurrentWeek { get; set; }
        public int CurrentDay { get; set; }

        public ShowUserAccountModel(ProjectPowerData.Folder.Models.UserAccounts dbEntity)
        {
            UserId = dbEntity.UserId;
            UserName = dbEntity.UserName;
            Password = dbEntity.Password;
            Email = dbEntity.Email;
            CurrentWeek = dbEntity.CurrentWeek;
            CurrentDay = dbEntity.CurrentDay;
        }
    }
}
