﻿using Reddit2.Entities;
using Reddit2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit2.Repositories
{
    public class PostRepository
    {
        private PostContext postContext;

        public PostRepository(PostContext postContext)
        {
            this.postContext = postContext;
        }

        public List<Post> GetAll()
        {
            return postContext.Post.ToList();
        }

        public Post GetItem(long id)
        {
            return postContext.Post.FirstOrDefault(p => p.PostId == id);
        }

        public void AddScore(long id)
        {
            Post update = GetItem(id);
            update.Score++;
            postContext.Post.Update(update);
            postContext.SaveChanges();
        }

        public void DecreaseScore(long id)
        {
            Post update = GetItem(id);
            update.Score--;
            postContext.Post.Update(update);
            postContext.SaveChanges();
        }
    }
}
