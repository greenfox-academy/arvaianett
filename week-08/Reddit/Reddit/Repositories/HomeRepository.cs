﻿using Microsoft.EntityFrameworkCore;
using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class HomeRepository
    {
        private HomeContext homeContext;

        public HomeRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

        public User GetCurrentUser(User user)
        {
            homeContext.RedditPosts.Load();
            return homeContext.RedditUsers.FirstOrDefault(u => u.UserId == user.UserId);
        }
    }
}
