﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{
    [Route("")]
    public class FoxController : Controller
    {
        public Fox fox;

        public FoxController(Fox fox)
        {
            this.fox = fox;
        }
        // GET: /<controller>/
        [HttpGet("nutrition/{name}")]
        public IActionResult Index()
        {
            return View(fox);
        }

        [HttpPost("changenutrition/{name}")]
        public IActionResult Nutrition(string name, string food, string drink)
        {
            fox.Food = food;
            fox.Drink = drink;

            return Redirect($"/index/{name}");
        }

        [HttpGet("tricks/{name}")]
        public IActionResult Tricks()
        {
            return View(fox);
        }

        [HttpPost("addtrick/{name}")]
        public IActionResult AddTricks(string name, string trick)
        {
            fox.ListOfTricks.Add(trick);

            return Redirect($"/index/{name}");
        }
    }
}
