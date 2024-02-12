using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;

namespace MediaList.WebUI.Controllers
{
    public class MangaController : Controller
    {
        private readonly IMangaService _mangaService;
        private readonly IMediaService _mediaService;

        public MangaController(IMangaService mangasService, IMediaService mediaService)
        {
            _mediaService = mediaService;
            _mangaService = mangasService;
        }

        public async Task<IActionResult> Index()
        {
            var mangas = await _mangaService.Get();
            return View(mangas);
        }

        public async Task<IActionResult> CreateAsync()
        {
            var newManga = new MangaViewModel
            {
                AllMediaTypes = await _mediaService.GetAllMediaTypes(),
                AllGenres = await _mediaService.GetAllGenres()
            };

            return View(newManga);
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
