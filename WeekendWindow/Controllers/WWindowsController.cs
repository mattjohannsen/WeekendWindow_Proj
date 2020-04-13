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
    public class WWindowsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WWindowsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WWindows
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WWindow.Include(w => w.ViewerLocation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WWindows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wWindow = await _context.WWindow
                .Include(w => w.ViewerLocation)
                .FirstOrDefaultAsync(m => m.WWindowId == id);
            if (wWindow == null)
            {
                return NotFound();
            }

            return View(wWindow);
        }

        // GET: WWindows/Create
        public IActionResult Create()
        {
            ViewData["WeekendLocationId"] = new SelectList(_context.ViewerLocation, "ViewerLocationId", "ViewerLocationName");
            ViewData["WeekendAttitudeId"] = new SelectList(_context.Attitude, "AttitudeId", "AttitudeName");
            ViewData["TravelRadiusId"] = new SelectList(_context.TravelRadius, "TravelRadiusId", "RadiusMiles");
            return View();
        }

        // POST: WWindows/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WWindowId,WeekendLocationId,SaturdayDate,SundayDate,SaturdayWeatherId,SundayWeatherId,WeekendAttitudeId,WantLodging,WeekendLodgingId,TravelRadiusId")] WWindow wWindow)
        {
            if (ModelState.IsValid)
            {
                var viewerLocation = _context.ViewerLocation.Where(a => a.ViewerLocationId == wWindow.WeekendLocationId).FirstOrDefault();
                wWindow.ViewerLocation = viewerLocation;
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Viewer currentviewer = _context.Viewers.Where(v => v.IdentityUserId == userId).FirstOrDefault();
                currentviewer.WWindow = wWindow;
                var viewerId = currentviewer.ViewerId;
                var testvariable = currentviewer.WWindow.ViewerLocation.ViewerLocationViewerId;
                _context.Add(wWindow);
                _context.Viewers.Update(currentviewer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["WeekendLocationId"] = new SelectList(_context.ViewerLocation, "ViewerLocationId", "ViewerLocationId", wWindow.WeekendLocationId);
            return View(wWindow);
        }

        // GET: WWindows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wWindow = await _context.WWindow.FindAsync(id);
            if (wWindow == null)
            {
                return NotFound();
            }
            ViewData["WeekendLocationId"] = new SelectList(_context.ViewerLocation, "ViewerLocationId", "ViewerLocationName");
            ViewData["WeekendAttitudeId"] = new SelectList(_context.Attitude, "AttitudeId", "AttitudeName");
            ViewData["TravelRadiusId"] = new SelectList(_context.TravelRadius, "TravelRadiusId", "RadiusMiles");
            return View(wWindow);
        }

        // POST: WWindows/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WWindowId,WeekendLocationId,SaturdayDate,SundayDate,SaturdayWeatherId,SundayWeatherId,WeekendAttitudeId,WantLodging,WeekendLodgingId,TravelRadiusId")] WWindow wWindow)
        {
            if (id != wWindow.WWindowId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wWindow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WWindowExists(wWindow.WWindowId))
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
            ViewData["WeekendLocationId"] = new SelectList(_context.ViewerLocation, "ViewerLocationId", "ViewerLocationId", wWindow.WeekendLocationId);
            return View(wWindow);
        }

        // GET: WWindows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wWindow = await _context.WWindow
                .Include(w => w.ViewerLocation)
                .FirstOrDefaultAsync(m => m.WWindowId == id);
            if (wWindow == null)
            {
                return NotFound();
            }

            return View(wWindow);
        }

        // POST: WWindows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wWindow = await _context.WWindow.FindAsync(id);
            _context.WWindow.Remove(wWindow);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WWindowExists(int id)
        {
            return _context.WWindow.Any(e => e.WWindowId == id);
        }
    }
}
