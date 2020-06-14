using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDidThatGame.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IDidThatGame.Controllers
{
    [Authorize(Roles = "Administrator, Registered user")]
    public class EditGameController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public EditGameController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> EditGame()
        {
            ViewData["AllActionItems"] = await ActionDb.GetActionsItems(_context);
            ViewData["AllPlaceItems"] = await PlaceDb.GetPlaceItems(_context);
            ViewData["AllChallengeItems"] = await ChallengeDb.GetChallengeItems(_context);
            return View();
        }
    }
}