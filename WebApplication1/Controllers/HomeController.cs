using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebApplication1.Models;
using System.Text.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult EnviarPDF(IFormFile arquivo, List<SelectedPage> pagesSelected)
        {
            if (arquivo == null || arquivo.Length == 0)
            {
                ModelState.AddModelError("", "Arquivo inválido.");
                return View("Index");
            }

            // Só para debug: ver quantos objetos chegaram
            System.Diagnostics.Debug.WriteLine($"Páginas recebidas: {pagesSelected?.Count ?? 0}");
            foreach (var p in pagesSelected ?? Enumerable.Empty<SelectedPage>())
            {
                System.Diagnostics.Debug.WriteLine($"Page: {p.PageNumber}, Copies: {p.Copies}");
            }

            // Passa para a view Modelo, incluindo o nome do arquivo no ViewBag
            ViewBag.FileName = arquivo.FileName;

            return View("~/Views/Impressao/Modelo.cshtml", pagesSelected);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
