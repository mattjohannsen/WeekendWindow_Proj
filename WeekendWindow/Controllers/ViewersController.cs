using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeekendWindow.Data;
using WeekendWindow.Models;

namespace WeekendWindow.Controllers
{
    public class ViewersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Viewers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Viewers.Include(v => v.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Viewers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewer = await _context.Viewers
                .Include(v => v.IdentityUser)
                .FirstOrDefaultAsync(m => m.ViewerId == id);
            if (viewer == null)
            {
                return NotFound();
            }

            return View(viewer);
        }

        // GET: Viewers/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Viewers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ViewerId,IdentityUserId,FirstName,LastName,HomeLocationId,NotificationDay")] Viewer viewer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                viewer.IdentityUserId = userId;
                _context.Add(viewer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", viewer.IdentityUserId);
            return View(viewer);
        }

        // GET: Viewers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewer = await _context.Viewers.FindAsync(id);
            if (viewer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", viewer.IdentityUserId);
            return View(viewer);
        }

        // POST: Viewers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ViewerId,IdentityUserId,FirstName,LastName,HomeLocationId,NotificationDay")] Viewer viewer)
        {
            if (id != viewer.ViewerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    viewer.IdentityUserId = userId;
                    _context.Update(viewer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViewerExists(viewer.ViewerId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", viewer.IdentityUserId);
            return View(viewer);
        }

        // GET: Viewers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewer = await _context.Viewers
                .Include(v => v.IdentityUser)
                .FirstOrDefaultAsync(m => m.ViewerId == id);
            if (viewer == null)
            {
                return NotFound();
            }

            return View(viewer);
        }

        // POST: Viewers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viewer = await _context.Viewers.FindAsync(id);
            _context.Viewers.Remove(viewer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViewerExists(int id)
        {
            return _context.Viewers.Any(e => e.ViewerId == id);
        }
    }
}
