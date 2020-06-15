using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IDidThatGame.Data;
using IDidThatGame.Models;
using Microsoft.AspNetCore.Authorization;

namespace IDidThatGame.Controllers
{
    [Authorize(Roles = "Administrator, Registered user")]
    public class PlaceItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaceItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlaceItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.Places.ToListAsync());
        }

        // GET: PlaceItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placeItem = await _context.Places
                .FirstOrDefaultAsync(m => m.PlaceId == id);
            if (placeItem == null)
            {
                return NotFound();
            }

            return View(placeItem);
        }

        // GET: PlaceItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PlaceItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlaceId,PlaceName,Category")] PlaceItem placeItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(placeItem);
                await _context.SaveChangesAsync();
                return RedirectToAction("EditGame", "EditGame");
            }
            return View(placeItem);
        }

        // GET: PlaceItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placeItem = await _context.Places.FindAsync(id);
            if (placeItem == null)
            {
                return NotFound();
            }
            return View(placeItem);
        }

        // POST: PlaceItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlaceId,PlaceName,Category")] PlaceItem placeItem)
        {
            if (id != placeItem.PlaceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(placeItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaceItemExists(placeItem.PlaceId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("EditGame", "EditGame");
            }
            return View(placeItem);
        }

        // GET: PlaceItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var placeItem = await _context.Places
                .FirstOrDefaultAsync(m => m.PlaceId == id);
            if (placeItem == null)
            {
                return NotFound();
            }

            return View(placeItem);
        }

        // POST: PlaceItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var placeItem = await _context.Places.FindAsync(id);
            _context.Places.Remove(placeItem);
            await _context.SaveChangesAsync();
            return RedirectToAction("EditGame", "EditGame");
        }

        private bool PlaceItemExists(int id)
        {
            return _context.Places.Any(e => e.PlaceId == id);
        }

        public static async Task<String> GetRandomPlace(ApplicationDbContext context)
        {
            Random random = new Random();
            List<PlaceItem> allPlaceItems = await PlaceDb.GetPlaceItems(context);
            string randomPlace = (allPlaceItems[random.Next(allPlaceItems.Count)]).PlaceName.ToString();
            return randomPlace;
        }

    }
}
