using Microsoft.AspNetCore.Mvc;

namespace BlazorLibrary.Server.Controllers;
public class TipoLibroController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
