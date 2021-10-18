using ProjectPower.Areas.A2S_Program.Helpers;
using ProjectPower.Areas.A2S_Program.Models.A2SWorkoutModels;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Service
{
    public class A2SWorkoutService : IA2SWorkoutService
    {
        private readonly DataContext _dc;
        private ICachingService _cachingService;
        public A2SWorkoutService(DataContext context, ICachingService cachingService)
        {
            _cachingService = cachingService;
            _dc = context;
        }

        public IEnumerable<ShowA2SWorkoutModel> GetIndexModel(A2SWorkoutSearchModel search)
        {
            var dbEntities = _dc.A2SWorkoutExercises;

            var model = new List<ShowA2SWorkoutModel>();
            foreach (var entity in dbEntities)
            {
                model.Add(new ShowA2SWorkoutModel(entity));
            }

            return model;
        }

        public int GetCount(A2SWorkoutSearchModel search)
        {
            var dbEntities = _dc.A2SWorkoutExercises;

            return dbEntities.Count();
        }

        public ShowA2SWorkoutModel GetShowModel(long id)
        {
            var dbEntity = _dc.A2SWorkoutExercises.Find(id);

            if (dbEntity == null)
            {
                return null;
            }
            else
            {
                return new ShowA2SWorkoutModel(dbEntity);
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
        public void SaveUpdateModel(UpdateA2SAmrapResultModel model)
        {
            var dbEntity = _dc.A2SWorkoutExercises.Find(model.Id);
            dbEntity.AmrapRepResult = model.AmrapRepResult;

            _dc.SaveChanges();
        }
        public CreateA2SWorkoutModel GetCreateModel()
        {
            return new CreateA2SWorkoutModel();
        }

        public ShowA2SWorkoutModel SaveCreateModel(CreateA2SWorkoutModel model)
        {
            var dbEntity = new A2SHyperTrophyModel();

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
