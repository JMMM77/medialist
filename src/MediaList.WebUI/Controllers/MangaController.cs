using Microsoft.AspNetCore.Mvc;
using MediaList.Data.Models;
using MediaList.Services.Interfaces;
using MediaList.Services.Models;
using AutoMapper;

namespace MediaList.WebUI.Controllers
{
    public class MangaController : Controller
    {
        private readonly IMangaService _mangaService;
        private readonly IMapper _mapper;
        private readonly IMediaService _mediaService;

        public MangaController(IMangaService mangasService, IMapper mapper, IMediaService mediaService)
        {
            _mangaService = mangasService;
            _mapper = mapper;
            _mediaService = mediaService;
            
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var mangas = await _mangaService.Get();
            return View(mangas);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var newManga = new MangaViewModel
            {
                AllMediaTypes = await _mediaService.GetAllMediaTypes(),
                AllGenres = await _mediaService.GetAllGenres()
            };

            return View(newManga);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MangaViewModel manga)
        {
            if (!ModelState.IsValid)
            {
                manga.AllMediaTypes = await _mediaService.GetAllMediaTypes();
                manga.AllGenres = await _mediaService.GetAllGenres();
                return View(manga);
            }

            await _mangaService.Post(_mapper.Map<Manga>(manga));

            return View(nameof(Details), manga);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string id = "0")
        {
            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            manga.AllMediaTypes = await _mediaService.GetAllMediaTypes();
            manga.AllGenres = await _mediaService.GetAllGenres();

            return View(manga);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id = "0")
        {
            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string id = "0")
        {
            var manga = await _mangaService.Get(id);

            if (manga == null)
            {
                return NotFound();
            }

            return View(manga);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(MangaViewModel manga)
        {
            if(manga.Id != null)
            {
                await _mangaService.Delete(manga.Id);
            }

            return RedirectToAction("Index");
        }
    }
}
