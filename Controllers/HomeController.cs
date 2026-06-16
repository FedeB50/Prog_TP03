using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ActBD.Models;

namespace ActBD.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado palabrasAhorcado = new PalabrasAhorcado();
        ViewBag.Palabra = palabrasAhorcado.ObtenerPalabra();
        return View();
    }

    public IActionResult ModificarPalabras()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
