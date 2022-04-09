using eBiletix.Data;
using eBiletix.Data.Services;
using eBiletix.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletix.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemaService _service;

        public CinemasController(ICinemaService service)
        {
            _service = service;
        }

        //public IActionResult Index()
        //{
        //    var data = _service.Cinemas.ToList();
        //    return View("Index", data);
        //}

        public async Task<IActionResult> Index()
        {
            var allCinema = await _service.GetAllAsync();
            return View("Index", allCinema);
        }

        //GET: Cinemas/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var cinemasDetails = await _service.GetByIdAsync(id);
            if (cinemasDetails == null) return View("NotFound");
            return View(cinemasDetails);
        }

        //GET: Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> Create([Bind("Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET: Cinemas/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var cinemasDetails = await _service.GetByIdAsync(id);
            if (cinemasDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemasDetails);
        }

        [HttpPost()]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            if (id == cinema.Id)
            {
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }
            return View(cinema);
        }

        //Get: Producers/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var cinemasDetails = await _service.GetByIdAsync(id);
            if (cinemasDetails == null) return View("NotFound");
            return View(cinemasDetails);
        }

        [HttpPost(), ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemasDetails = await _service.GetByIdAsync(id);
            if (cinemasDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
