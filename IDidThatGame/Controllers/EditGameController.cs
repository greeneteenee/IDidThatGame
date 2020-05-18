using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IDidThatGame.Controllers
{
    [Authorize(Roles = "Administrator, Registered user")]
    public class EditGameController : Controller
    {
        public IActionResult EditGame()
        {
            return View();
        }
    }
}