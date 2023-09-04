using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

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
            return View(new MangaViewModel());
        }

        [HttpPost]
        public IActionResult Create(MangaViewModel manga)
        {
            return View("Details", manga.Id);
        }

        public async Task<IActionResult> Details(string id = "0")
        {
            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        public async Task<IActionResult> Edit(string id = "0")
        {
            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        public async Task<IActionResult> Delete(string id = "0")
        {
            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }
    }
}
