﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IDidThatGame.Models;
using IDidThatGame.Data;

namespace IDidThatGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }  

       
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public async Task<IActionResult> GetRandomAction()
        {
            Random random = new Random();
            List<ActionItem> allActionItems = await ActionDb.GetActionsItems(_context);
            var randomAction = allActionItems[random.Next(allActionItems.Count)];
            string randomActionName = randomAction.ActionName;

            ViewData["RandomAction"] = randomActionName;
            return View("Index");
        }

        public async Task<IActionResult> GetRandomPlace()
        {
            Random random = new Random();
            List<PlaceItem> allPlaceItems = await PlaceDb.GetPlaceItems(_context);
            var randomPlace = allPlaceItems[random.Next(allPlaceItems.Count)];
            string randomPlaceName = randomPlace.PlaceName;

            ViewData["RandomPlace"] = randomPlaceName;
            return View("Index");
        }

        public async Task<IActionResult> GetRandomChallenge()
        {
            Random random = new Random();
            List<ChallengeItem> allChallengeItems = await ChallengeDb.GetChallengeItems(_context);
            var randomChallenge = allChallengeItems[random.Next(allChallengeItems.Count)];
            string randomChallengeName = randomChallenge.ChallengeName;

            ViewData["RandomChallenge"] = randomChallengeName;
            return View("Index");
        }

    }
}
