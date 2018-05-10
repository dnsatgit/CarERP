using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarERPv2.Models;

namespace CarERPv2.Controllers
{
    public class RequestsController : Controller
    {
        private readonly CarERPv2Context _context;

        public RequestsController(CarERPv2Context context)
        {
            _context = context;
        }

        // GET: Requests
        public async Task<IActionResult> Index()
        {
            var carERPv2Context = _context.Request.Include(r => r.customer).Include(r => r.items).Include(r => r.service);
            return View(await carERPv2Context.ToListAsync());
        }

        // GET: Requests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request
                .Include(r => r.customer)
                .Include(r => r.items)
                .Include(r => r.service)
                .SingleOrDefaultAsync(m => m.RequestID == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // GET: Requests/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "FirstNameMI");
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemID");
            ViewData["ServicesID"] = new SelectList(_context.Set<Services>(), "ServicesID", "ServicesID");
            return View();
        }

        // POST: Requests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestID,ServicesID,CustomerID,ItemID,Vehicle,Description,Cost")] Request request)
        {
            if (ModelState.IsValid)
            {
                _context.Add(request);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "FirstNameMI", request.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemID", request.ItemID);
            ViewData["ServicesID"] = new SelectList(_context.Set<Services>(), "ServicesID", "ServicesID", request.ServicesID);
            return View(request);
        }

        // GET: Requests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request.SingleOrDefaultAsync(m => m.RequestID == id);
            if (request == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "FirstNameMI", request.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemID", request.ItemID);
            ViewData["ServicesID"] = new SelectList(_context.Set<Services>(), "ServicesID", "ServicesID", request.ServicesID);
            return View(request);
        }

        // POST: Requests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestID,ServicesID,CustomerID,ItemID,Vehicle,Description,Cost")] Request request)
        {
            if (id != request.RequestID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(request);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequestExists(request.RequestID))
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
            ViewData["CustomerID"] = new SelectList(_context.Customer, "CustomerID", "FirstNameMI", request.CustomerID);
            ViewData["ItemID"] = new SelectList(_context.Item, "ItemID", "ItemID", request.ItemID);
            ViewData["ServicesID"] = new SelectList(_context.Set<Services>(), "ServicesID", "ServicesID", request.ServicesID);
            return View(request);
        }

        // GET: Requests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var request = await _context.Request
                .Include(r => r.customer)
                .Include(r => r.items)
                .Include(r => r.service)
                .SingleOrDefaultAsync(m => m.RequestID == id);
            if (request == null)
            {
                return NotFound();
            }

            return View(request);
        }

        // POST: Requests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var request = await _context.Request.SingleOrDefaultAsync(m => m.RequestID == id);
            _context.Request.Remove(request);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequestExists(int id)
        {
            return _context.Request.Any(e => e.RequestID == id);
        }
    }
}
