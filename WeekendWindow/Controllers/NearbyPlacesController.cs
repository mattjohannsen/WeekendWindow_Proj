using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeekendWindow.Contracts;
using WeekendWindow.Data;
using WeekendWindow.Models;
using WeekendWindow.ViewModels;

namespace WeekendWindow.Controllers
{
    public class NearbyPlacesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private INearbySearchRequest _nearbySearchRequest;

        public NearbyPlacesController(ApplicationDbContext context, INearbySearchRequest nearbySearchRequest)
        {
            _context = context;
            _nearbySearchRequest = nearbySearchRequest;
        }

        // GET: NearbyPlaces
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var viewer = _context.Viewers.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            NearbyPlaces nearbyPlaces = await _nearbySearchRequest.GetNearbyPlaces();
            MapViewModel mapView = new MapViewModel()
            {
                NearbyPlaces = nearbyPlaces,
                Viewer = viewer
            };
            
            return View(mapView);
        }

        // GET: NearbyPlaces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nearbyPlaces = await _context.NearbyPlaces
                .FirstOrDefaultAsync(m => m.NearbyPlacesId == id);
            if (nearbyPlaces == null)
            {
                return NotFound();
            }

            return View(nearbyPlaces);
        }

        // GET: NearbyPlaces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NearbyPlaces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NearbyPlacesId,next_page_token,status")] NearbyPlaces nearbyPlaces)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nearbyPlaces);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nearbyPlaces);
        }

        // GET: NearbyPlaces/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nearbyPlaces = await _context.NearbyPlaces.FindAsync(id);
            if (nearbyPlaces == null)
            {
                return NotFound();
            }
            return View(nearbyPlaces);
        }

        // POST: NearbyPlaces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NearbyPlacesId,next_page_token,status")] NearbyPlaces nearbyPlaces)
        {
            if (id != nearbyPlaces.NearbyPlacesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nearbyPlaces);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NearbyPlacesExists(nearbyPlaces.NearbyPlacesId))
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
            return View(nearbyPlaces);
        }

        // GET: NearbyPlaces/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nearbyPlaces = await _context.NearbyPlaces
                .FirstOrDefaultAsync(m => m.NearbyPlacesId == id);
            if (nearbyPlaces == null)
            {
                return NotFound();
            }

            return View(nearbyPlaces);
        }

        // POST: NearbyPlaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nearbyPlaces = await _context.NearbyPlaces.FindAsync(id);
            _context.NearbyPlaces.Remove(nearbyPlaces);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NearbyPlacesExists(int id)
        {
            return _context.NearbyPlaces.Any(e => e.NearbyPlacesId == id);
        }
    }
}
