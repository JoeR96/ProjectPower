using Microsoft.EntityFrameworkCore;
using ProjectPower.Areas.WorkoutCreation.Weekly;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPower.Repositories.Interfaces
{
    public class ExerciseRepository : IExerciseRepository
    {
        DataContext _dc;

        public ExerciseRepository(DataContext context) => _dc = context;
        public async Task AddAsync(Exercise exercise) => _dc.Exercises.Add(exercise);
        
        public async Task<List<Exercise>> FindCurrentWorkout(User user)
        {
            return (List<Exercise>)_dc.Exercises.Where(e => e.UserName == user.UserName && e.ExerciseDay == user.CurrentDay && e.Week == user.CurrentWeek).OrderBy(exercise => exercise.ExerciseOrder);
        }

        public async Task<Exercise> FindWeeklyExercise(FindWeeklyExercise exercise)
        {
            return await _dc.Exercises
               .Where(e => e.ExerciseMasterId == exercise.ExerciseMasterId && e.Week == exercise.Week)
               .FirstOrDefaultAsync();
        }
    }
}
