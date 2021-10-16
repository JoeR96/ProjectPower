using ProjectPower.Areas.A2S_Program.Models.BaseWorkoutInformationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.A2S_Program.Service.Interfaces
{
    public interface IBasicWorkoutInformationService
    {
        IEnumerable<ShowBasicWorkoutInformationModel> GetIndexModel(BasicWorkoutInformationSearchModel search);
        int GetCount(BasicWorkoutInformationSearchModel search);

        ShowBasicWorkoutInformationModel GetShowModel(long id);

        ShowBasicWorkoutInformationModel GetShowModelByName(string name);

        UpdateBasicWorkoutInformationModel GetUpdateModel(long id);

        void SaveUpdateModel(long id, UpdateBasicWorkoutInformationModel model);

        CreateBasicWorkoutInformationModel GetCreateModel();

        ShowBasicWorkoutInformationModel SaveCreateModel(CreateBasicWorkoutInformationModel model);

        void Delete(long id);
    }
}
