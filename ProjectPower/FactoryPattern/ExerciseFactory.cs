using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;

namespace ProjectPower.FactoryPattern
{
    public abstract class ExerciseFactory

    {
        protected readonly DataContext _dc;
        public ExerciseFactory()
        {
            _dc = new DataContext();
        }
        public abstract void CreateExercise(CreateExerciseModel template);

        public void CreateBaseExercise(CreateExerciseModel model,BasicWorkoutInformation dbEntity)
        {
            dbEntity.Name = model.ExerciseName;
            dbEntity.Category = model.Category;
            dbEntity.ExerciseDay = model.LiftDay;
            dbEntity.ExerciseOrder = model.LiftOrder;
            dbEntity.Template = model.Template;
            dbEntity.UserName = model.Username;
        }
        internal abstract void UpdateExercise(UpdateBasicWorkoutInformationModel model, BasicWorkoutInformation exercise);
    } 
}
