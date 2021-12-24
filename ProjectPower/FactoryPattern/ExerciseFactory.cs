using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;

namespace ProjectPower.FactoryPattern
{
    public abstract class ExerciseFactory
    {
        protected readonly DataContext _dc;
        protected IBasicWorkoutInformation _basicWorkoutInformation;
        //need an abstracte type/interface for models to inherit from 
        //have to populate base+template @ same time g
        //woz blazed
        public ExerciseFactory()
        {
            _dc = new DataContext();
        }
        public abstract void CreateExercise(CreateExerciseModel template);

        public string CreateBaseExercise(CreateExerciseModel model)
        {
            var id = Guid.NewGuid().ToString();

            dbEntity.Name = model.ExerciseName;
            dbEntity.Category = model.Category;
            dbEntity.ExerciseDay = model.LiftDay;
            dbEntity.ExerciseOrder = model.LiftOrder;
            dbEntity.Template = model.Template;
            dbEntity.UniqueId = id;
            dbEntity.UserName = model.Username;
            _dc.BasicWorkoutInformation.Add(dbEntity);
            _dc.SaveChanges();
            return id;
        }
    }

   
}
