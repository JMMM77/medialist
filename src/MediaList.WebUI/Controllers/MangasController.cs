using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Services;

namespace MediaList.WebUI.Controllers
{
    public class MangasController : Controller
    {
        private readonly IMangaService _mangaService;

        public MangasController(IMangaService MangasService)
        {
            _mangaService = MangasService;
        }

        public async Task<IActionResult> Index()
        {
            var mangas = await _mangaService.Get();
            return View(mangas);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }


    }
}
