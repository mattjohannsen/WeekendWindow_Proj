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
    public class ViewerLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewerLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ViewerLocations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ViewerLocation.Include(v => v.State).Include(v => v.Viewer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ViewerLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewerLocation = await _context.ViewerLocation
                .Include(v => v.State)
                .Include(v => v.Viewer)
                .FirstOrDefaultAsync(m => m.ViewerLocationId == id);
            if (viewerLocation == null)
            {
                return NotFound();
            }

            return View(viewerLocation);
        }

        // GET: ViewerLocations/Create
        public IActionResult Create()
        {
            ViewData["ViewerLocationStateId"] = new SelectList(_context.State, "StateId", "StateName");
            ViewData["ViewerLocationViewerId"] = new SelectList(_context.Viewers, "ViewerId", "ViewerId");
            return View();
        }

        // POST: ViewerLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ViewerLocationId,ViewerLocationViewerId,ViewerLocationName,ViewerLocationAddress,ViewerLocationCity,ViewerLocationStateId,ViewerLocationZip,ViewerLocationLong,ViewerLocationLat,ViewerIsHomeLocation")] ViewerLocation viewerLocation)
        {
            if (ModelState.IsValid)
            {
                //Add code here to put the Viewer's ViewerId into database.
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                Viewer currentviewer = _context.Viewers.Where(v=> v.IdentityUserId == userId).FirstOrDefault();
                viewerLocation.ViewerLocationViewerId = currentviewer.ViewerId;
                _context.Add(viewerLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ViewerLocationStateId"] = new SelectList(_context.State, "StateId", "StateAbbreviation", viewerLocation.ViewerLocationStateId);
            //ViewData["ViewerLocationViewerId"] = new SelectList(_context.Viewers, "ViewerId", "ViewerId", viewerLocation.ViewerLocationViewerId);
            return View(viewerLocation);
        }

        // GET: ViewerLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewerLocation = await _context.ViewerLocation.FindAsync(id);
            if (viewerLocation == null)
            {
                return NotFound();
            }
            ViewData["ViewerLocationStateId"] = new SelectList(_context.State, "StateId", "StateAbbreviation", viewerLocation.ViewerLocationStateId);
            //ViewData["ViewerLocationViewerId"] = new SelectList(_context.Viewers, "ViewerId", "ViewerId", viewerLocation.ViewerLocationViewerId);
            return View(viewerLocation);
        }

        // POST: ViewerLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ViewerLocationId,ViewerLocationViewerId,ViewerLocationName,ViewerLocationAddress,ViewerLocationCity,ViewerLocationStateId,ViewerLocationZip,ViewerLocationLong,ViewerLocationLat,ViewerIsHomeLocation")] ViewerLocation viewerLocation)
        {
            if (id != viewerLocation.ViewerLocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //Here is where we update the ViewerId
                    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    Viewer currentviewer = _context.Viewers.Where(v => v.IdentityUserId == userId).FirstOrDefault();
                    viewerLocation.ViewerLocationViewerId = currentviewer.ViewerId;
                    _context.Update(viewerLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViewerLocationExists(viewerLocation.ViewerLocationId))
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
            ViewData["ViewerLocationStateId"] = new SelectList(_context.State, "StateId", "StateName", viewerLocation.ViewerLocationStateId);
            ViewData["ViewerLocationViewerId"] = new SelectList(_context.Viewers, "ViewerId", "ViewerId", viewerLocation.ViewerLocationViewerId);
            return View(viewerLocation);
        }

        // GET: ViewerLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewerLocation = await _context.ViewerLocation
                .Include(v => v.State)
                .Include(v => v.Viewer)
                .FirstOrDefaultAsync(m => m.ViewerLocationId == id);
            if (viewerLocation == null)
            {
                return NotFound();
            }

            return View(viewerLocation);
        }

        // POST: ViewerLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viewerLocation = await _context.ViewerLocation.FindAsync(id);
            _context.ViewerLocation.Remove(viewerLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViewerLocationExists(int id)
        {
            return _context.ViewerLocation.Any(e => e.ViewerLocationId == id);
        }
    }
}
