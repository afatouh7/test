using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmpApp.Data;
using EmpApp.Models;
using System.Data;
using ClosedXML.Excel;
using System.IO;

namespace EmpApp.Controllers
{
    public class LineofBusinessesController : Controller
    {
        private readonly DataContext _context;

        public LineofBusinessesController(DataContext context)
        {
            _context = context;
        }

        // GET: LineofBusinesses
        public async Task<IActionResult> Index()
        {
            return View(await _context.LineofBusinesses.ToListAsync());
        }

        // GET: LineofBusinesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lineofBusiness = await _context.LineofBusinesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lineofBusiness == null)
            {
                return NotFound();
            }

            return View(lineofBusiness);
        }

        // GET: LineofBusinesses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LineofBusinesses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Account")] LineofBusiness lineofBusiness)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lineofBusiness);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lineofBusiness);
        }

        // GET: LineofBusinesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lineofBusiness = await _context.LineofBusinesses.FindAsync(id);
            if (lineofBusiness == null)
            {
                return NotFound();
            }
            return View(lineofBusiness);
        }

        // POST: LineofBusinesses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Account")] LineofBusiness lineofBusiness)
        {
            if (id != lineofBusiness.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lineofBusiness);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LineofBusinessExists(lineofBusiness.Id))
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
            return View(lineofBusiness);
        }

        // GET: LineofBusinesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lineofBusiness = await _context.LineofBusinesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lineofBusiness == null)
            {
                return NotFound();
            }

            return View(lineofBusiness);
        }

        // POST: LineofBusinesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lineofBusiness = await _context.LineofBusinesses.FindAsync(id);
            _context.LineofBusinesses.Remove(lineofBusiness);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LineofBusinessExists(int id)
        {
            return _context.LineofBusinesses.Any(e => e.Id == id);
        }
        
    }
}

