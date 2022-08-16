using ProjectPower.Areas.WorkoutCreation.Weekly;
using ProjectPowerData.Folder.Models;

namespace ProjectPower.Repositories.Interfaces
{
    public interface IExerciseRepository
    {
        Task AddAsync(Exercise exercise);
        Task<List<Exercise>> FindCurrentWorkout(User userAccount);
        Task<Exercise> FindWeeklyExercise(FindWeeklyExercise exercise);

    }
}
