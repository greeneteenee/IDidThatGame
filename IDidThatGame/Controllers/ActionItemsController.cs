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
    public class ActionItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActionItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ActionItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.Actions.ToListAsync());
        }

        // GET: ActionItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actionItem = await _context.Actions
                .FirstOrDefaultAsync(m => m.ActionId == id);
            if (actionItem == null)
            {
                return NotFound();
            }

            return View(actionItem);
        }

        // GET: ActionItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ActionItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActionId,ActionName,Category,Advanced")] ActionItem actionItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(actionItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(actionItem);
        }

        // GET: ActionItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actionItem = await _context.Actions.FindAsync(id);
            if (actionItem == null)
            {
                return NotFound();
            }
            return View(actionItem);
        }

        // POST: ActionItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ActionId,ActionName,Category,Advanced")] ActionItem actionItem)
        {
            if (id != actionItem.ActionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(actionItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActionItemExists(actionItem.ActionId))
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
            return View(actionItem);
        }

        // GET: ActionItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actionItem = await _context.Actions
                .FirstOrDefaultAsync(m => m.ActionId == id);
            if (actionItem == null)
            {
                return NotFound();
            }

            return View(actionItem);
        }

        // POST: ActionItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actionItem = await _context.Actions.FindAsync(id);
            _context.Actions.Remove(actionItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActionItemExists(int id)
        {
            return _context.Actions.Any(e => e.ActionId == id);
        }
    }
}
