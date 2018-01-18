﻿using Reddit.Entities;
using Reddit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public class PostRepository
    {
        private HomeContext homeContext;

        public PostRepository(HomeContext homeContext)
        {
            this.homeContext = homeContext;
        }

        public void AddScore(Post post)
        {
            post.Score++;
            UpdatePost(post);
        }

        public void DecreaseScore(Post post)
        {
            post.Score--;
            UpdatePost(post);
        }

        public void UpdatePost(Post post)
        {
            homeContext.RedditPosts.Update(post);
            homeContext.SaveChanges();
        }
    }
}
