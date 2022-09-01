using ProjectPower.Areas.WorkoutCreation.Models;
using ProjectPower.Areas.WorkoutCreation.Models.BaseWorkoutInformationService;
using ProjectPower.FactoryPattern;
using ProjectPowerData.Folder.Models;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProjectPowerTests")]
namespace ProjectPower.Areas.A2S_Program.Factories
{
    public class A2SRepsThenSetsFactory : ExerciseFactory
    {
        public override void CreateExercise(CreateExerciseModel model)
        {
            const int workoutTotalDuration = 20;
            var masterId = Guid.NewGuid();

            for (int i = 0; i < workoutTotalDuration; i++)
            {
                var dbEntity = new A2SSetsThenReps();
                CreateBaseExercise(model, dbEntity);
                dbEntity.ExerciseMasterId = masterId.ToString();
                dbEntity.RepIncreasePerSet = (int)model.RepIncreasePerSet;
                dbEntity.GoalReps = (int)model.GoalReps;
                dbEntity.GoalSets = (int)model.GoalSets;
                dbEntity.StartingSets = (int)model.StartingSets;
                dbEntity.StartingReps = (int)model.StartingReps;
                dbEntity.StartingWeight = (int)model.StartingWeight;
                dbEntity.CurrentSets = (int)model.StartingSets;
                dbEntity.CurrentReps = (int)model.StartingReps;
                dbEntity.Week = i + 1;
                _dc.Exercises.Add(dbEntity);
            }

            _dc.SaveChanges();

        }

        internal override void UpdateExercise(UpdateWeeklyExerciseModel model, ProjectPowerData.Folder.Models.Exercise exercise)
        {
            var currentExercise = (A2SSetsThenReps)exercise;
            var nextWeekExercise = (A2SSetsThenReps)_dc.Exercises.Where(e => e.ExerciseMasterId == exercise.ExerciseMasterId && e.Week == currentExercise.Week + 1).FirstOrDefault();

            ProgressExercise(currentExercise, nextWeekExercise);

            currentExercise.ExerciseCompleted = true;
            _dc.Exercises.Update(nextWeekExercise);
            _dc.Exercises.Update(currentExercise);

            _dc.SaveChanges();
        }

        public override void ProgressExercise(ProjectPowerData.Folder.Models.Exercise currentWeek, ProjectPowerData.Folder.Models.Exercise nextWeek)
        {
            A2SSetsThenReps c = (A2SSetsThenReps)currentWeek;
            A2SSetsThenReps n = (A2SSetsThenReps)nextWeek;

            if (c.CurrentReps >= c.GoalReps && c.CurrentSets < c.GoalSets)
            {
                n.CurrentReps = c.CurrentReps += c.RepIncreasePerSet;
            }
            else if (c.CurrentSets < c.GoalSets)
            {
                n.CurrentReps = n.StartingReps;
                n.CurrentSets += 1;
            }
            else
            {
                n.CurrentReps = n.StartingReps;
                n.CurrentSets = n.StartingSets;
            }
        }
    }
}
