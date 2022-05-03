using ProjectPower.Areas.WorkoutCreation.Weekly;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectPower.Repositories.Interfaces
{
    public interface IExerciseRepository
    {
        Task AddAsync(Exercise exercise);
        Task<List<Exercise>> FindCurrentWorkout(User userAccount);
        Task<Exercise> FindWeeklyExercise(FindWeeklyExercise exercise);
        
    }
}
