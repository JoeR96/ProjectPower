using ProjectPower.Areas.UserAccounts.Communication;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPower.Repositories.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectPower.Areas.UserAccounts.Services
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IUserAccountRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPasswordHasherService _passwordHasher;

        public UserAccountService(IUserAccountRepository userRepository, IUnitOfWork unitOfWork, IPasswordHasherService passwordHasher)
        {
            _passwordHasher = passwordHasher;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public async Task<CreateUserResponse> CreateUserAccountAsync(User user, params ApplicationRole[] userRoles)
        {
            try
            {
                var existingUser = await _userRepository.FindByEmailAsync(user.Email);
                if (existingUser != null)
                {
                    return new CreateUserResponse(false, "Email already in use.", null);
                }

                user.Password = _passwordHasher.HashPassword(user.Password);

                await _userRepository.AddAsync(user, userRoles);
                await _unitOfWork.CompleteAsync();

                return new CreateUserResponse(true, null, user);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> FindByEmailAsync(string email)
        {
            return await _userRepository.FindByEmailAsync(email);
        }
    }
}
