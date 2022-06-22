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
using Funding_MVC_.Interface;

namespace Funding_MVC_.Controllers
{
    public class FundCategoriesController : Controller
    {
        private readonly IFundCategoryRepository _fundCategoryRepository;
        private readonly IMapper _mapper;

        public FundCategoriesController(IFundCategoryRepository fundCategoryRepository, IMapper mapper)
        {
            _fundCategoryRepository = fundCategoryRepository;
            _mapper = mapper;
        }



        // GET: FundCategories  / have to modify a little bit
        public async Task<IActionResult> Index()
        {
            var fundCategories = _mapper.Map<List<FundCategoryVM>>(await _fundCategoryRepository.GetAllAsync());
            return View(fundCategories);
        }



        // GET: FundCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var fundCategory = await _fundCategoryRepository.GetAsync(id);
            if (fundCategory == null)
            {
                return NotFound();
            }
            var fundCategoryVM = _mapper.Map<FundCategoryVM>(fundCategory);
            return View(fundCategoryVM);
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
                await _fundCategoryRepository.AddAsync(fundCategory);
                return RedirectToAction(nameof(Index));
            }
            return View(fundCategoryVM);
        }


        // GET: FundCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            var fundCategoryVM = _mapper.Map<FundCategoryVM>(id);
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
                    await _fundCategoryRepository.UpdateAsync(fundCategory);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await FundCategoryExistsAsync(fundCategoryVM.Id))
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



        // POST: FundCategories/Delete/5          / have to change a little bit
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _fundCategoryRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> FundCategoryExistsAsync(int id)
        {
            return await _fundCategoryRepository.Exists(id);
        }
    }
}
