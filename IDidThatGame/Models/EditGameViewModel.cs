using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IDidThatGame.Data;
using IDidThatGame.Models;

namespace IDidThatGame.Models
{
    public class EditGameViewModel
    {
        public List<ActionItem> actions { get; set; }
        public List<PlaceItem> places { get; set; }
        public List<ChallengeItem> challenges { get; set; }

        private readonly ApplicationDbContext _context; //c# convention to use underscore to set field instead of using this keyword down below, "readonly" means only the constructor can modify this variable

        public EditGameViewModel(ApplicationDbContext context) //constructor gives controller access to database
        {
            _context = context;
        }

        public async Task<List<ActionItem>> GetActions() 
        {
            return actions = await ActionDb.GetActionsItems(_context);
        }

        public async Task<List<PlaceItem>> GetPlaces()
        {
            return places = await PlaceDb.GetPlaceItems (_context);
        }

        public async Task<List<ChallengeItem>> GetChallenges()
        {
            return challenges = await ChallengeDb.GetChallengeItems(_context);
        }

    }
}
