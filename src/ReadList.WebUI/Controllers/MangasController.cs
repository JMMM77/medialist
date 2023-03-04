using Microsoft.AspNetCore.Mvc;
using ReadList.Data.Models;
using ReadList.Services.Interfaces;
using ReadList.Services.Services;

namespace ReadList.WebUI.Controllers
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

        public IActionResult Details()
        {
            return View();
        }
    }
}
