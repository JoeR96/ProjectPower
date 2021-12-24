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

        public CreateBasicWorkoutInformationModel GetCreateModel()
        {
            return new CreateBasicWorkoutInformationModel();
        }


        public void Delete(long id)
        {
            var dbEntity = _dc.BasicWorkoutInformation.Find(id);
            _dc.Remove(dbEntity);
            _dc.SaveChanges();
        }   
    }
}
