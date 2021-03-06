﻿using Reddit2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Services
{
    public class LoginService
    {
        private LoginRepository loginRepository;

        public LoginService(LoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public bool UserStatus(string username)
        {
            return loginRepository.UserStatus(username);
        }

        public void AddUser(string username)
        {
            loginRepository.AddUser(username);
        }
    }
}
