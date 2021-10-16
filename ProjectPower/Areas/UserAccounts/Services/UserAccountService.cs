using ProjectPower.Areas.UserAccounts.Helpers;
using ProjectPower.Areas.UserAccounts.Models.UserAccounts;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPower.Areas.UserAccounts.Services
{
    public class UserAccountService : IUserAccountService
    {
        private readonly DataContext _dc;

        public UserAccountService(DataContext context)
        {
            _dc = context;
        }
        
        public IEnumerable<ShowUserAccountModel> GetIndexModel(UserAccountSearchModel search)
        {
            var dbEntities = _dc.UserAccounts;

            var model = new List<ShowUserAccountModel>();
            foreach(var entity in dbEntities)
            {
                model.Add(new ShowUserAccountModel(entity));
            }

            return model;
        }

        public int GetCount(UserAccountSearchModel search)
        {
            var dbEntities = _dc.UserAccounts;

            return dbEntities.Count();
        }

        public ShowUserAccountModel GetShowModel(long id)
        {
            var dbEntity = _dc.UserAccounts.Find(id);

            if(dbEntity == null)
            {
                return null;
            }
            else
            {
                return new ShowUserAccountModel(dbEntity);
            }
        }

        public ShowUserAccountModel GetShowModelByEmail(string email)
        {
            var dbEntity = _dc.UserAccounts.FirstOrDefault(x => x.Email == email);

            if(dbEntity == null)
            {
                return null;
            }
            else
            {
                return new ShowUserAccountModel(dbEntity);
            }
        }
        public UpdateUserAccountModel GetUpdateModel(long id)
        {
            var dbEntity = _dc.UserAccounts.Find(id);

            if(dbEntity == null)
            {
                return null;
            }
            else
            {
                return new UpdateUserAccountModel(dbEntity);
            }
        }
        public void SaveUpdateModel(long id, UpdateUserAccountModel model)
        {
            var dbEntity = _dc.UserAccounts.Find(id);
            dbEntity.UserName = model.UserName;
            dbEntity.Password = UserAccountsHelpers.HashPassword(model.Password);
            dbEntity.Email = model.Email;

            _dc.SaveChanges();
        }
        public CreateUserAccountModel GetCreateModel()
        {
            return new CreateUserAccountModel();
        }

        public ShowUserAccountModel SaveCreateModel(CreateUserAccountModel model)
        {
            var dbEntity = new ProjectPowerData.Folder.Models.UserAccounts();

            dbEntity.UserName = model.UserName;
            dbEntity.Password = UserAccountsHelpers.HashPassword(model.Password);
            dbEntity.Email = model.Email;

            _dc.UserAccounts.Add(dbEntity);
            _dc.SaveChanges();

            return new ShowUserAccountModel(dbEntity);
        }

        public void Delete(long id)
        {
            var dbEntity = _dc.UserAccounts.Find(id);
            _dc.Remove(dbEntity);
            _dc.SaveChanges();
        }

    }
}
