using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Funding_MVC_.Data;
using AutoMapper;
using Funding_MVC_.Models;

namespace Funding_MVC_.Controllers
{
    public class FundCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FundCategoriesController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: FundCategories  / have to modify a little bit
        public async Task<IActionResult> Index()
        {
            var fundCategories = _mapper.Map<List<FundCategoryVM>>(await _context.FundCategories.ToListAsync());
            return View(fundCategories);
        }

        // GET: FundCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.FundCategories == null)
            {
                return NotFound();
            }

            var fundCategory = await _context.FundCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fundCategory == null)
            {
                return NotFound();
            }

            return View(fundCategory);
        }


        // GET: FundCategories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FundCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FundCategoryVM fundCategoryVM)
        {
            if (ModelState.IsValid)
            {
                var fundCategory = _mapper.Map<FundCategory>(fundCategoryVM);
                _context.Add(fundCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fundCategoryVM);
        }



        // GET: FundCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.FundCategories == null)
            {
                return NotFound();
            }

            var fundCategory = await _context.FundCategories.FindAsync(id);
            if (fundCategory == null)
            {
                return NotFound();
            }

            var fundCategoryVM = _mapper.Map<FundCategoryVM>(fundCategory);
            return View(fundCategoryVM);
        }

        // POST: FundCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FundCategoryVM fundCategoryVM)
        {
            if (id != fundCategoryVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var fundCategory = _mapper.Map<FundCategory>(fundCategoryVM);
                    _context.Update(fundCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FundCategoryExists(fundCategoryVM.Id))
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
            return View(fundCategoryVM);
        }

        // GET: FundCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.FundCategories == null)
            {
                return NotFound();
            }

            var fundCategory = await _context.FundCategories
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fundCategory == null)
            {
                return NotFound();
            }

            return View(fundCategory);
        }






        // POST: FundCategories/Delete/5          / have to change a little bit
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var fundCategory = await _context.FundCategories.FindAsync(id);
                _context.FundCategories.Remove(fundCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FundCategoryExists(int id)
        {
          return (_context.FundCategories?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
