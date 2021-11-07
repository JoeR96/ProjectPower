using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Service
{
    public class A2SWorkoutService : IA2SWorkoutService
    {
        private readonly DataContext _dc;
        private ICachingService _cachingService;
        private A2STemplateValues _a2sHelper = new A2STemplateValues();
        public A2SWorkoutService(DataContext context, ICachingService cachingService)
        {
            _cachingService = cachingService;
            _dc = context;
        }

        public List<UnassignedWorkoutModel> GetUnassignedExercises(A2SWorkoutSearchModel search)
        {
            var unassginedExercises = _dc.A2SWorkoutExercises
                .Where(e => search.Term == e.Username &&
                    e.LiftOrder == null
                        && e.LiftDay == null).Select(e => new UnassignedWorkoutModel
                        {
                            ExerciseName = e.Name,
                            UniqueId = e.UniqueId,

                        }).Distinct().ToList();
                            

            return unassginedExercises;
        }

        public int GetCount(A2SWorkoutSearchModel search)
        {
            var dbEntities = _dc.A2SWorkoutExercises;

            return dbEntities.Count();
        }

        List<A2SDailyWorkoutModel> IA2SWorkoutService.GetDailyWorkout(GetA2SWeeklyWorkout workout)
        {
            var exercises = _dc.A2SWorkoutExercises
               .Where(w => w.Week == workout.Week &&
                   w.LiftDay == workout.Day &&
                       w.Username == workout.Username)
               .Select(e => new A2SDailyWorkoutModel(e))
                .ToList();

            if (exercises == null)
            {
                return null;
            }
            else
            {
                return exercises;
            }
        }

        public ShowA2SWorkoutModel GetShowModelByName(string name)
        {
            var dbEntity = _dc.A2SWorkoutExercises.FirstOrDefault(x => x.Name == name);

            if (dbEntity == null)
            {
                return null;
            }
            else
            {
                return new ShowA2SWorkoutModel(dbEntity);
            }
        }
        public UpdateA2SAmrapResultModel GetUpdateModel(long id)
        {
            var dbEntity = _dc.A2SWorkoutExercises.Find(id);

            if (dbEntity == null)
            {
                return null;
            }
            else
            {

                return new UpdateA2SAmrapResultModel(dbEntity);
            }
        }
        public void SaveAmrapResult(UpdateA2SAmrapResultModel model,long id)
        {
            var dbEntity = _dc.A2SWorkoutExercises.FirstOrDefault(m => m.Id == id);
            dbEntity.AmrapRepResult = model.AmrapRepResult;

            _dc.SaveChanges();
        }
        public CreateA2SWorkoutModel GetCreateModel()
        {
            return new CreateA2SWorkoutModel();
        }

        public ShowA2SWorkoutModel SaveCreateModel(CreateA2SWorkoutModel model)
        {
            var dbEntity = new A2SHyperTrophy();

            var scaffold = new A2SScaffoldDatabase(_dc);
            scaffold.PopulateA2SWorkout(model);
            _dc.SaveChanges();

            return new ShowA2SWorkoutModel(dbEntity);
        }

        public void Delete(long id)
        {
            var dbEntity = _dc.A2SWorkoutExercises.Find(id);
            _dc.Remove(dbEntity);
            _dc.SaveChanges();
        }

       
    }
}
