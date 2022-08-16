using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectPowerTests")]
namespace ProjectPower.FactoryPattern
{
    public abstract class ExerciseFactory

    {
        protected readonly DataContext _dc;
        protected static ExerciseFactory Factory;
        public ExerciseFactory()
        {
            _dc = new DataContext();
            Factory = this;
        }
        public abstract void CreateExercise(CreateExerciseModel template);

        public void CreateBaseExercise(CreateExerciseModel model, ProjectPowerData.Folder.Models.Exercise dbEntity)
        {
            dbEntity.Name = model.ExerciseName;
            dbEntity.Category = model.Category;
            dbEntity.ExerciseDay = model.LiftDay;
            dbEntity.ExerciseOrder = model.LiftOrder;
            dbEntity.Template = model.Template;
            dbEntity.UserName = model.Username;
        }
        internal abstract void UpdateExercise(UpdateWeeklyExerciseModel model, ProjectPowerData.Folder.Models.Exercise exercise);

        public abstract void ProgressExercise(ProjectPowerData.Folder.Models.Exercise currentWeek, ProjectPowerData.Folder.Models.Exercise nextWeek);

    }
}
