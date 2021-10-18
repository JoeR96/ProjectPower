using System.ComponentModel.DataAnnotations;

namespace ProjectPower.Areas.UserAccounts.Services.Models
{
    public class UserCacheInformationModel
    {
        public string UserName { get; set; }
        [Required]
        public int CurrentDay { get; set; }
        [Required]
        public int CurrentWeek { get; set; }

        public UserCacheInformationModel(ProjectPowerData.Folder.Models.UserAccounts dbEntity)
        {
            CurrentDay = dbEntity.CurrentDay;
            CurrentWeek = dbEntity.CurrentWeek;
            UserName = dbEntity.UserName;
        }
    }
}
