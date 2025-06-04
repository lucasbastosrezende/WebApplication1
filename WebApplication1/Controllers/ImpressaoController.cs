using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ImpressaoController : Controller
    {
        public IActionResult Modelo(List<SelectedPage> pagesSelected, string fileName)
        {
            // Envie para a view os dados
            ViewBag.FileName = fileName;
            return View(pagesSelected);
        }
    }

}
