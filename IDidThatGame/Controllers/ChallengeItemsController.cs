using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IDidThatGame.Data;
using IDidThatGame.Models;

namespace IDidThatGame.Controllers
{
    public class ChallengeItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ChallengeItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ChallengeItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.Challenges.ToListAsync());
        }

        // GET: ChallengeItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var challengeItem = await _context.Challenges
                .FirstOrDefaultAsync(m => m.ChallengeId == id);
            if (challengeItem == null)
            {
                return NotFound();
            }

            return View(challengeItem);
        }

        // GET: ChallengeItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ChallengeItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ChallengeId,ChallengeName,Category,Advanced")] ChallengeItem challengeItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(challengeItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(challengeItem);
        }

        // GET: ChallengeItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var challengeItem = await _context.Challenges.FindAsync(id);
            if (challengeItem == null)
            {
                return NotFound();
            }
            return View(challengeItem);
        }

        // POST: ChallengeItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ChallengeId,ChallengeName,Category,Advanced")] ChallengeItem challengeItem)
        {
            if (id != challengeItem.ChallengeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(challengeItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChallengeItemExists(challengeItem.ChallengeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(challengeItem);
        }

        // GET: ChallengeItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var challengeItem = await _context.Challenges
                .FirstOrDefaultAsync(m => m.ChallengeId == id);
            if (challengeItem == null)
            {
                return NotFound();
            }

            return View(challengeItem);
        }

        // POST: ChallengeItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var challengeItem = await _context.Challenges.FindAsync(id);
            _context.Challenges.Remove(challengeItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChallengeItemExists(int id)
        {
            return _context.Challenges.Any(e => e.ChallengeId == id);
        }

        public static async Task<String> GetRandomChallenge(ApplicationDbContext context)
        {
            Random random = new Random();
            List<ChallengeItem> allChallengeItems = await ChallengeDb.GetChallengeItems(context);
            string randomChallenge = (allChallengeItems[random.Next(allChallengeItems.Count)]).ChallengeName.ToString();
            return randomChallenge;
        }

    }
}
