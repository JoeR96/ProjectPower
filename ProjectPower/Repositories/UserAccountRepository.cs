using Microsoft.EntityFrameworkCore;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.Repositories.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Repositories
{
    public class UserAccountRepository : IUserAccountRepository
    {
        DataContext _dc;

        public UserAccountRepository(DataContext context) => _dc = context;

        public async Task AddAsync(User userAccount, ApplicationRole[] userRoles)
        {
            //var roleNames = userRoles.Select(r => r.ToString()).ToList();
            //var roles = await _dc.Roles.Where(r => roleNames.Contains(r.Name)).ToListAsync();

            //foreach (var role in roles)
            //{
            //    userAccount.UserRoles.Add(new UserRole { RoleId = role.Id });
            //}

            _dc.UserAccounts.Add(userAccount);
            _dc.SaveChangesAsync();
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            var x = await _dc.UserAccounts.Include(u => u.UserRoles)
                                      .ThenInclude(ur => ur.Role)
                                      .FirstOrDefaultAsync(u => u.Email == email);
            var y = x;
            return x;
        }

        public async Task<Exercise> FindExerciseByWeekAndDayAsync(UpdateWeeklyExerciseModel model)
        {
            return await _dc.Exercises
               .Where(e => e.ExerciseMasterId == model.ExerciseMasterId && e.Week == model.Week)
               .FirstOrDefaultAsync();
        }
    }
}


