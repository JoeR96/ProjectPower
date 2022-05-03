using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.FactoryPattern;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectPowerTests")]
namespace ProjectPower.Areas.A2S_Program.Factories
{
    public class A2SHypertrophyFactory : ExerciseFactory
    {
        A2SHypertrophyTemplateValues helper = new A2SHypertrophyTemplateValues();
        public static new A2SHypertrophyFactory Factory { get; set; }

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

                    _dc.Exercises.Add(dbEntity);

                }
            }
            _dc.SaveChanges();

        }

        internal override void UpdateExercise(UpdateWeeklyExerciseModel model, ProjectPowerData.Folder.Models.Exercise exercise)
        {
            var currentWeekExercise = (A2SHyperTrophy)exercise;
            currentWeekExercise.AmrapRepResult = model.Reps;
            var nextWeekExercise = (A2SHyperTrophy)_dc.Exercises.Where(e => e.ExerciseMasterId == exercise.ExerciseMasterId && e.Week == currentWeekExercise.Week + 1).FirstOrDefault();
            
            ProgressExercise(currentWeekExercise, nextWeekExercise);

            currentWeekExercise.ExerciseCompleted = true;

            _dc.Exercises.Update(currentWeekExercise);
            _dc.Exercises.Update(nextWeekExercise);
            _dc.SaveChanges();
        }

        public override void ProgressExercise(ProjectPowerData.Folder.Models.Exercise curr, ProjectPowerData.Folder.Models.Exercise next)
        {
            A2SHyperTrophy nextWeek = (A2SHyperTrophy)next;
            A2SHyperTrophy currentWeek = (A2SHyperTrophy)curr;
            int updateModifier = 0;
            Math.Clamp(updateModifier, -2, 5);

            updateModifier = (int)(currentWeek.AmrapRepResult - currentWeek.AmrapRepTarget);
            nextWeek.TrainingMax = UpdateTrainingMax(currentWeek.TrainingMax, updateModifier);
            Math.Clamp(updateModifier, -2, 5);

            SetWorkingWeight(nextWeek);
            currentWeek.ExerciseTargetCompleted = currentWeek.AmrapRepResult >= currentWeek.AmrapRepTarget;
        }

        internal void SetWorkingWeight(A2SHyperTrophy model)
        {
            var workingWeight = model.Intensity * model.TrainingMax;
            var newWeight = Math.Round(workingWeight / model.RoundingValue);
            model.WorkingWeight = newWeight * model.RoundingValue;
        }

        internal decimal UpdateTrainingMax(decimal trainingMax, int updateModifier)
        {
            decimal modifier = 0;
            switch (updateModifier)
            {
                case -2: modifier = -2m; break;
                case -1: modifier = -1m; break;
                case 0: modifier = 0m; break;
                case 1: modifier = 0.5m; break;
                case 2: modifier = 1m; break;
                case 3: modifier = 1.5m; break;
                case 4: modifier = 2m; break;
                case 5: modifier = 3m; break;
                default: modifier = 0m; break;
            }

            return trainingMax / 100 * (100 + modifier);
        }
        public void CreateDummyData()
        {

            for (int i = 0; i < 16; i++)
            {
                var e = (A2SHyperTrophy)_dc.Exercises.Where(e => e.Name == "Deadlift" && e.UserName == "DummyData" && e.Week == i + 1).FirstOrDefault();

                UpdateWeeklyExerciseModel model = new UpdateWeeklyExerciseModel();
                model.ExerciseMasterId = e.ExerciseMasterId;
                var rnd = new Random();

                model.Reps = e.AmrapRepTarget + rnd.Next(0,6);

                model.Week = i + 1;
                if(i < 16)
                {
                    UpdateExercise(model, e);
                }
                else
                {

                }
            }
        }
    }
}
