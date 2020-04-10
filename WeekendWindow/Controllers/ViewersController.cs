using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WeekendWindow.Contracts;
using WeekendWindow.Data;
using WeekendWindow.Models;
using WeekendWindow.Services;
using WeekendWindow.ViewModels;

namespace WeekendWindow.Controllers
{
    public class ViewersController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IForecastRequest _forecastRequest;
        private readonly IGeoCodeRequest _geoCodeRequest;

        public ViewersController(ApplicationDbContext context, IForecastRequest forecastRequest, IGeoCodeRequest geoCodeRequest)
        {
            _forecastRequest = forecastRequest;
            _geoCodeRequest = geoCodeRequest;
            _context = context;
        }

        // GET: Viewers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            Viewer viewer = _context.Viewers.Where(v => v.IdentityUserId == userId).FirstOrDefault();
            if (viewer != null)
            {
                //var data = new List<WeatherForecast>();

                WeatherForecast forecast = await _forecastRequest.GetWeatherForecast();
                DateTime dt = DateTime.Today;
                DayOfWeek dw = dt.DayOfWeek;

                int num = (int)DateTime.Today.DayOfWeek;
                int num2 = (int)dw;

                DateTime satNum = DateTime.Today.AddDays(6 - num2);
                DateTime sunNum = satNum.AddDays(1);

                string sat = satNum.ToString("yyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
                string sun = sunNum.ToString("yyy-MM-dd", DateTimeFormatInfo.InvariantInfo);

                var data = forecast.data.Where(d => (d.valid_date == sat) || (d.valid_date == sun)).ToList();

                ViewData["City"] = forecast.city_name;
                ViewData["State"] = forecast.state_code;

                //Saturday Weather
                ViewData["SatDate"] = data[0].valid_date;
                ViewData["SatHighTemp"] = data[0].high_temp;
                ViewData["SatLowTemp"] = data[0].low_temp;
                ViewData["SatWindSpeed"] = data[0].wind_spd;
                ViewData["SatGustsTo"] = data[0].wind_gust_spd;
                ViewData["SatWindDir"] = data[0].wind_dir;
                ViewData["SatSkies"] = data[0].weather.description;

                //Sunday Weather
                ViewData["SunDate"] = data[1].valid_date;
                ViewData["SunHighTemp"] = data[1].high_temp;
                ViewData["SunLowTemp"] = data[1].low_temp;
                ViewData["SunWindSpeed"] = data[1].wind_spd;
                ViewData["SunGustsTo"] = data[1].wind_gust_spd;
                ViewData["SunWindDir"] = data[1].wind_dir;
                ViewData["SunSkies"] = data[1].weather.description;


                return View(forecast);

                //var applicationDbContext = _context.Viewers.Include(v => v.IdentityUser);
                //return View(await applicationDbContext.ToListAsync());
            }
            else
            {
                return RedirectToAction(nameof(Create));
            }

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
            ViewData["States"] = new SelectList(_context.State, "StateAbbreviation", "StateName");
         
            return View();
        }

        // POST: Viewers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ViewerId,IdentityUserId,FirstName,LastName,ViewerPhone,HomeLocationId,NotificationDay, ViewerAddress, ViewerCity, ViewerState, ViewerZip, ViewerLong, ViewerLat")] Viewer viewer)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                viewer.IdentityUserId = userId;
                string address = (viewer.ViewerAddress.ToString() + ", +" + viewer.ViewerCity.ToString() + ",+" + viewer.ViewerState.ToString());
                GeoLocation location = await _geoCodeRequest.GetGeoLocation(address);
                viewer.ViewerLat = location.results[0].geometry.location.lat.ToString();
                viewer.ViewerLong = location.results[0].geometry.location.lng.ToString();
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
            ViewData["States"] = new SelectList(_context.State, "StateAbbreviation", "StateName");
            return View(viewer);
        }

        // POST: Viewers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ViewerId,IdentityUserId,FirstName,LastName,ViewerPhone,HomeLocationId,NotificationDay,ViewerAddress, ViewerCity, ViewerState, ViewerZip, ViewerLong, ViewerLat")] Viewer viewer)  
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
                    string address = (viewer.ViewerAddress.ToString() + ", +" + viewer.ViewerCity.ToString() + ",+" + viewer.ViewerState.ToString());
                    GeoLocation location = await _geoCodeRequest.GetGeoLocation(address);
                    viewer.ViewerLat = location.results[0].geometry.location.lat.ToString();
                    viewer.ViewerLong = location.results[0].geometry.location.lng.ToString();
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
