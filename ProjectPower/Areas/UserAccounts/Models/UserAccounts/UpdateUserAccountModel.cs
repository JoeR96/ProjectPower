using System.ComponentModel.DataAnnotations;


namespace ProjectPower.Areas.UserAccounts.Models.UserAccounts
{

    public class UpdateUserAccountModel : IValidatableObject
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int CurrentDay { get; set; }
        public int CurrentWeek { get; set; }
        public UpdateUserAccountModel(ProjectPowerData.Folder.Models.User entity)
        {
            CurrentWeek = entity.CurrentWeek;
            CurrentDay = entity.CurrentDay;
            UserName = entity.UserName;
            Email = entity.Email;
            Password = entity.Password;
        }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Password.Length < 6)
            {
                yield return new ValidationResult("Password must be greater than 6 characters", new List<string> { nameof(Password) });
            }
        }
    }
}
