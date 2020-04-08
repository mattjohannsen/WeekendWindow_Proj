using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using WeekendWindow.Data;
using WeekendWindow.Models;

namespace WeekendWindow.Controllers
{
    public class AdminsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminsController(ApplicationDbContext context)
        {
            _context = context;
            CreateSMS();
            //SendSms1().Wait(); 
            //ViewersController.CreateNotification();
        }

        //public async Task<IActionResult> Index(string dayToNotify = null)
        //{
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    Admin currentadmin = _context.Admins.Where(e => e.IdentityUserId == userId).FirstOrDefault();
        //    string dayToCheck = DateTime.Now.DayOfWeek.ToString();
        //    string dateToCheck = DateTime.Now.ToShortDateString();
        //    DateTime? DTdateToCheck = DateTime.Parse(dateToCheck);
        //    if (dayToNotify != null)
        //    {
        //        dayToCheck = dayToNotify;
        //    }
        //    var notifyList = _context.Viewers.Where(c => c.NotificationDay == dateToCheck).ToList();

        //    currentadmin.ViewersToNotify = notifyList;

        //    var notifyByDay = new List<DayOfWeek>();
        //    notifyByDay.Add(DayOfWeek.Monday);
        //    notifyByDay.Add(DayOfWeek.Tuesday);
        //    notifyByDay.Add(DayOfWeek.Wednesday);
        //    notifyByDay.Add(DayOfWeek.Thursday);
        //    notifyByDay.Add(DayOfWeek.Friday);
        //    notifyByDay.Add(DayOfWeek.Saturday);
        //    notifyByDay.Add(DayOfWeek.Sunday);
        //    //currentadmin.workDays = notifyByDay;

        //    return View(currentadmin);
        //}

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Admins.Include(a => a.IdentityUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .Include(a => a.IdentityUser)
                .FirstOrDefaultAsync(m => m.AdminId == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdminId,IdentityUserId,FirstName,LastName")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", admin.IdentityUserId);
            return View(admin);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", admin.IdentityUserId);
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdminId,IdentityUserId,FirstName,LastName")] Admin admin)
        {
            if (id != admin.AdminId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(admin.AdminId))
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
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", admin.IdentityUserId);
            return View(admin);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .Include(a => a.IdentityUser)
                .FirstOrDefaultAsync(m => m.AdminId == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(int id)
        {
            return _context.Admins.Any(e => e.AdminId == id);
        }

        public IActionResult CreateSMS()
        {

            var currentDay = DateTime.Now.DayOfWeek.ToString();
            
          
            var viewersList = _context.Viewers.Where(v => v.NotificationDay == currentDay).ToList();
            //Admin admin = new Admin();
            //admin.ViewersToNotify = viewersList;now 
            //var routesByDay = new List<DayOfWeek>();
            //routesByDay.Add(DayOfWeek.Monday);
            //routesByDay.Add(DayOfWeek.Tuesday);
            //routesByDay.Add(DayOfWeek.Wednesday);
            //routesByDay.Add(DayOfWeek.Thursday);
            //routesByDay.Add(DayOfWeek.Friday);
            //routesByDay.Add(DayOfWeek.Saturday);
            //routesByDay.Add(DayOfWeek.Sunday);
            //currentemployee.workDays = routesByDay;


            //SendSms1();
            return View(viewersList);
        }
        public static async Task SendSms1()
        {

            const string accountSid = APIKEYS.TwilioSid;
            const string authToken = APIKEYS.TwilioToken;

            TwilioClient.Init(accountSid, authToken);

            var message = await MessageResource.CreateAsync(
                body: "Time to set up your awesome weekend!!!",
                from: new Twilio.Types.PhoneNumber("+19135218316"),
                to: new Twilio.Types.PhoneNumber("+13607204065")
            );

            Console.WriteLine(message.Sid);
        }

    }
}
