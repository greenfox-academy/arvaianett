﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit2.Services;
using Reddit2.ViewModels;
using Reddit2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit2.Controllers
{
    [Route("")]
    public class PostController : Controller
    {
        private PostService postService;
        private PostViewModel postViewModel;

        public PostController(PostService postService, PostViewModel postViewModel)
        {
            this.postService = postService;
            this.postViewModel = postViewModel;
        }

        // GET: /<controller>/
        [HttpGet("posts")]
        public IActionResult Index()
        {
            return View(postService.GetListForView());
        }

        [HttpGet("addscore/{id}")]
        public IActionResult AddScore(long id)
        {
            postService.AddScore(id);
            return RedirectToAction("index");
        }

        [HttpGet("decreasescrore/{id}")]
        public IActionResult DecreaseScore(long id)
        {
            postService.DecreaseScore(id);
            return RedirectToAction("index");
        }

        //[HttpGet("bestten")]
        //public IActionResult BestTen()
        //{
        //    return View(postService.BestTen());
        //}
    }
}