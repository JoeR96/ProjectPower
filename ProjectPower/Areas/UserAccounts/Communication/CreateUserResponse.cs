﻿using ProjectPowerData.Folder.Models;

namespace ProjectPower.Areas.UserAccounts.Communication
{
    public class CreateUserResponse : BaseResponse
    {
        public User User { get; private set; }

        public CreateUserResponse(bool success, string message, User user) : base(success, message)
        {
            User = user;
        }
    }
}
