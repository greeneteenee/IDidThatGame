using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IDidThatGame.Models;
using IDidThatGame.Data;
using GameLogic;
using Microsoft.AspNetCore.Html;

namespace IDidThatGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private static Game thisGame = new Game();
        private static Player player1 = new Player();
        private static Player player2 = new Player();        
       

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
            player1.PlayerName = "Thing 1";
            player2.PlayerName = "Thing 2";
        }  

       
        

        public IActionResult Index()
        {
            DisplayNumberOfTurns();
            HighlightActivePlayer();
            HideThumbsButtons();           
            TempData["Player1Score"] = player1.PlayerScore.ToString();
            TempData["Player2Score"] = player2.PlayerScore.ToString();
            TempData.Keep();
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

        public IActionResult NewGame()
        {
            player1.ResetPlayerScore(player1);
            player2.ResetPlayerScore(player2);           
            thisGame.ResetTurns(thisGame);
            TempData.Clear();
            DisplayNumberOfTurns();
            HideThumbsButtons();          
            TempData.Keep();
            return View("Index");
        }

        public async Task<IActionResult> GetRandomAction()
        {
            Random random = new Random();
            List<ActionItem> allActionItems = await ActionDb.GetActionsItems(_context);
            var randomAction = allActionItems[random.Next(allActionItems.Count)];
            string randomActionName = randomAction.ActionName;         
            TempData["RandomAction"] = randomActionName;
            TempData["ActionCardState"] = "disabled";
           
            if (AllCardsFlipped() == true)
            {
                TempData["Visibility"] = "";
            }
            TempData.Keep();         
            return View("Index");
        }

        public async Task<IActionResult> GetRandomPlace()
        {
            Random random = new Random();
            List<PlaceItem> allPlaceItems = await PlaceDb.GetPlaceItems(_context);
            var randomPlace = allPlaceItems[random.Next(allPlaceItems.Count)];
            string randomPlaceName = randomPlace.PlaceName;           
            TempData["RandomPlace"] = randomPlaceName;
            TempData["PlaceCardState"] = "disabled";
           
            if (AllCardsFlipped() == true)
            {
                TempData["Visibility"] = "";
            }
            TempData.Keep();          
            return View("Index");
        }

        public async Task<IActionResult> GetRandomChallenge()
        {
            Random random = new Random();
            List<ChallengeItem> allChallengeItems = await ChallengeDb.GetChallengeItems(_context);
            var randomChallenge = allChallengeItems[random.Next(allChallengeItems.Count)];
            string randomChallengeName = randomChallenge.ChallengeName;          
            TempData["RandomChallenge"] = randomChallengeName;
            TempData["ChallengeCardState"] = "disabled";
          
            if (AllCardsFlipped() == true)
            {
                TempData["Visibility"] = "";
            }
            TempData.Keep();          
            return View("Index");
        }

        /// <summary>
        /// Returns true if all game cardsa are disabled (i.e. flipped)
        /// </summary>
        /// <returns></returns>
        public bool AllCardsFlipped()
        {
            if((string)TempData["ActionCardState"] == "disabled" && (string)TempData["PlaceCardState"] == "disabled" && (string)TempData["ChallengeCardState"] == "disabled")
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Increases player score, hides thumbs buttons and ends player turn
        /// </summary>
        /// <returns>Index view</returns>
        public IActionResult ThumbsUp()
        {
            if (thisGame.turn == false)
            {
                player1.UpdatePlayerScore(player1);
                TempData["Player1Score"] = player1.PlayerScore.ToString();
            }
            else
            {
                player2.UpdatePlayerScore(player2);
                TempData["Player2Score"] = player2.PlayerScore.ToString();
            }
            PlayerTurn(thisGame.turn);
          
            return View("Index");
        }

        /// <summary>
        /// Hides thumbs buttons and ends player turn
        /// </summary>
        /// <returns>Index view</returns>
        public IActionResult ThumbsDown()
        {
            PlayerTurn(thisGame.turn);
           
            return View("Index");
        }

        public void PlayerTurn(bool turn) 
        {
            //increment number of turns on each turn
            thisGame.numTurns += 1;

            HideThumbsButtons();         

            //if there's no more turns, display winner
            if (thisGame.OutOfTurns(thisGame.numTurns) == true)
            {
                string winnerName = thisGame.CheckWinner(player1, player2);
                TempData["WinnerName"] = winnerName;
                TempData["WinnerTxt"] = "is the";
                TempData["Winner"] = "WINNER";
                TempData["PlayAgainLink"] = "CLICK HERE";
                TempData["PlayAgainTxt"] = "to play again";
                
            }
            else
            {
                //change turn
                thisGame.turn = thisGame.ChangeTurn(turn);
                HighlightActivePlayer();

                //show number of turns left on game form
                int turnsLeft = thisGame.TurnsLeft(thisGame.numTurns);
                TempData["NumberTurnsLeft"] = turnsLeft.ToString();

              
                //reset game cards
                TempData["ActionCardState"] = "enabled";
                TempData["PlaceCardState"] = "enabled";
                TempData["ChallengeCardState"] = "enabled";
                TempData["RandomAction"] = "";
                TempData["RandomPlace"] = "";
                TempData["RandomChallenge"] = "";

                TempData.Keep();
            }
        }

        /// <summary>
        /// Displays number of turns
        /// </summary>
        public void DisplayNumberOfTurns()
        {
            TempData["NumberTurnsLeft"] = thisGame.TurnsLeft(thisGame.numTurns).ToString();
        }

        public void HighlightActivePlayer()
        {
            if (thisGame.turn == false)
            {
                TempData["HighlightP1"] = "border-left border-bottom shadow-sm";
                TempData["HighlightP2"] = "";
            }
            else
            {
                TempData["HighlightP1"] = "";
                TempData["HighlightP2"] = "border-right border-bottom shadow-sm";
            }
        }

        public void HideThumbsButtons()
        {
            TempData["Visibility"] = "invisible";
        }

        public IActionResult DisplayWinner() 
        {
            return View();
        }

    }
}
