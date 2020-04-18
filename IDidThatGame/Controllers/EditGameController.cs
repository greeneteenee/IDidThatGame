using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IDidThatGame.Controllers
{
    public class EditGameController : Controller
    {
        public IActionResult EditGame()
        {
            return View();
        }
    }
}