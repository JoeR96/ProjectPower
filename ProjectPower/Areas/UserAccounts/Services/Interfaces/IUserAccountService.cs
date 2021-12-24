using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Services.Interfaces
{
    public interface IUserAccountService
    {
        IEnumerable<ShowUserAccountModel> GetIndexModel(UserAccountSearchModel search);

        int GetCount(UserAccountSearchModel search);

        ShowUserAccountModel GetShowModel(long id);

        ShowUserAccountModel GetShowModelByUsername(string email);

        UpdateUserAccountModel GetUpdateModel(long id);

        void SaveUpdateModel(long id, UpdateUserAccountModel model);

        CreateUserAccountModel GetCreateModel();

        ShowUserAccountModel SaveCreateModel(CreateUserAccountModel model);

        void Delete(long id);
        UserCacheInformationModel Login(UserAccountLoginModel model);

    }
}
