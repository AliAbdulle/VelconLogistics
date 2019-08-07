using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VelconLogistics.Models;
using VelconLogistics.Models.LoadViewModel;
using VOLogistics.Data;
using VOLogistics.Models;

namespace VelconLogistics.Controllers
{
    [Authorize]
    public class LoadsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public LoadsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        // GET: Loads
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Load.Include(l => l.Driver).Include(l => l.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Loads/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var load = await _context.Load
                .Include(l => l.Driver)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.LoadId == id);
            if (load == null)
            {
                return NotFound();
            }

            return View(load);
        }

        // GET: Loads/Create
        public async Task<IActionResult> Create()
        {
            var currentUser = await GetCurrentUserAsync();
            var viewModel = new LoadCreateViewModels
            {
                
                AvailableDriver = await _context
                .Driver.Where(d => d.UserId == currentUser.Id).ToListAsync()
            };
            return View(viewModel);
        }

        // POST: Loads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LoadCreateViewModels viewModels)
        {
            ModelState.Remove("Load.User");
            ModelState.Remove("Load.Driver");
            ModelState.Remove("Load.UserId");

            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                var Load = viewModels.Load;
                Load.UserId = currentUser.Id;
                _context.Add(Load);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            viewModels.AvailableDriver = await _context.Driver.ToListAsync();
            return View(viewModels);
        }
    
        // GET: Loads/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            var currentUser = await GetCurrentUserAsync();
            var viewModel = new LoadCreateViewModels
            {

                AvailableDriver = await _context
                .Driver.Where(d => d.UserId == currentUser.Id).ToListAsync()
            };
            return View(viewModel);
        }


        // POST: Loads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoadId,CompanyName,Amount,PickupDate,DeliverdDate,Location,DriverId,IsDeliverd,UserId")] Load load)
        {
            if (id != load.LoadId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = await GetCurrentUserAsync();
                    load.User = currentUser;
                    _context.Update(load);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoadExists(load.LoadId))
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
            ViewData["DriverId"] = new SelectList(_context.Driver, "UserId", "FullName", load.UserId);
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", load.DriverId);
            return View(load);
        }

        // GET: Loads/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var load = await _context.Load
                .Include(l => l.Driver)
                .Include(l => l.User)
                .FirstOrDefaultAsync(m => m.LoadId == id);
            if (load == null)
            {
                return NotFound();
            }

            return View(load);
        }

        // POST: Loads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var load = await _context.Load.FindAsync(id);
            _context.Load.Remove(load);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoadExists(int id)
        {
            return _context.Load.Any(e => e.LoadId == id);
        }
    }
}
