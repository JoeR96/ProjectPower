using ProjectPower.Areas.A2S_Program.Models.BaseWorkoutInformationService;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.A2S_Program.Service
{
    class BasicWorkoutInformationService : IBasicWorkoutInformationService
    {
        private readonly DataContext _dc;

        public BasicWorkoutInformationService(DataContext context)
        {
            _dc = context;
        }
        public IEnumerable<ShowBasicWorkoutInformationModel> GetIndexModel(BasicWorkoutInformationSearchModel search)
        {
            var dbEntities = _dc.BasicWorkoutInformation;

            var model = new List<ShowBasicWorkoutInformationModel>();
            foreach (var entity in dbEntities)
            {
                model.Add(new ShowBasicWorkoutInformationModel(entity));
            }

            return model;
        }

        public int GetCount(BasicWorkoutInformationSearchModel search)
        {
            var dbEntities = _dc.BasicWorkoutInformation;

            return dbEntities.Count();
        }

        public ShowBasicWorkoutInformationModel GetShowModel(long id)
        {
            var dbEntity = _dc.BasicWorkoutInformation.Find(id);

            if (dbEntity == null)
            {
                return null;
            }
            else
            {
                return new ShowBasicWorkoutInformationModel(dbEntity);
            }
        }

        public ShowBasicWorkoutInformationModel GetShowModelByName(string name)
        {
            var dbEntity = _dc.BasicWorkoutInformation.FirstOrDefault(x => x.Name == name);

            if (dbEntity == null)
            {
                return null;
            }
            else
            {
                return new ShowBasicWorkoutInformationModel(dbEntity);
            }
        }
        public UpdateBasicWorkoutInformationModel GetUpdateModel(long id)
        {
            var dbEntity = _dc.BasicWorkoutInformation.Find(id);

            if (dbEntity == null)
            {
                return null;
            }
            else
            {
                return new UpdateBasicWorkoutInformationModel(dbEntity);
            }
        }
        public void SaveUpdateModel(long id, UpdateBasicWorkoutInformationModel model)
        {
            var dbEntity = _dc.BasicWorkoutInformation.Find(id);
            dbEntity.Name = model.Name;
            dbEntity.Category = model.Category;


            _dc.SaveChanges();
        }
        public CreateBasicWorkoutInformationModel GetCreateModel()
        {
            return new CreateBasicWorkoutInformationModel();
        }

        public ShowBasicWorkoutInformationModel SaveCreateModel(CreateBasicWorkoutInformationModel model)
        {
            var dbEntity = new BasicWorkoutInformation();

            dbEntity.Name = model.Name;
            dbEntity.Category = model.Category;


            _dc.BasicWorkoutInformation.Add(dbEntity);
            _dc.SaveChanges();

            return new ShowBasicWorkoutInformationModel(dbEntity);
        }

        public void Delete(long id)
        {
            var dbEntity = _dc.BasicWorkoutInformation.Find(id);
            _dc.Remove(dbEntity);
            _dc.SaveChanges();
        }   
    }
}
