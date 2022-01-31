using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.ExerciseCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.FactoryPattern;
using ProjectPowerData.Folder.Models;
using System;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Factories
{
    public class A2SHypertrophyFactory : ExerciseFactory
    {
        A2SHypertrophyTemplateValues helper = new A2SHypertrophyTemplateValues();

        public override void CreateExercise(CreateExerciseModel model)
        {
            var fullWorkout = (bool)model.AuxillaryLift == true ? helper.A2SAuxLifts : helper.A2SPrimaryLifts;
            var masterId = Guid.NewGuid();

            int week = 0;
            for (int i = 0; i < 3; i++)
            {
                var currentBlock = fullWorkout.ElementAt(i);

                for (int j = 0; j < 6; j++)
                {
                    var weeklyValues = currentBlock.Value;
                    var dbEntity = new A2SHyperTrophy();
                    CreateBaseExercise(model, dbEntity);
                    week++;
                    dbEntity.UserName = model.Username;
                    dbEntity.TrainingMax = (decimal)model.TrainingMax;
                    dbEntity.AuxillaryLift = (bool)model.AuxillaryLift;
                    dbEntity.Block = currentBlock.Key;
                    dbEntity.AmrapRepTarget = weeklyValues.amrapRepTarget[j];
                    dbEntity.AmrapRepResult = 0;
                    dbEntity.Week = week;
                    dbEntity.Intensity = weeklyValues.intensity[j];
                    dbEntity.Sets = weeklyValues.sets;
                    dbEntity.RepsPerSet = weeklyValues.repsPerSet[j];
                    dbEntity.ExerciseMasterId = masterId.ToString();
                    _dc.BasicWorkoutInformation.Add(dbEntity);
                    _dc.SaveChanges();

                }
            }
        }

        internal override void UpdateExercise(UpdateBasicWorkoutInformationModel model, BasicWorkoutInformation exercise)
        {
            var hypertrophyExercise = (A2SHyperTrophy)exercise;
            hypertrophyExercise.AmrapRepResult = model.Reps;
            var nextWeek = (A2SHyperTrophy)_dc.BasicWorkoutInformation.Where(e => e.ExerciseMasterId == exercise.ExerciseMasterId && e.Week == hypertrophyExercise.Week + 1).FirstOrDefault();
            A2SHelper.ProgressA2SHypertrophy(hypertrophyExercise, nextWeek);


            hypertrophyExercise.ExerciseCompleted = true;
            _dc.BasicWorkoutInformation.Update(hypertrophyExercise);
            _dc.BasicWorkoutInformation.Update(nextWeek);
            _dc.SaveChanges();
        }
    }
}
