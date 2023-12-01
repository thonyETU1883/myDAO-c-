using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dao.Models;

namespace dao.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Personnel personnel = new Personnel();
        List<object[]> a = personnel.getannotationcolumn();
        foreach(object[] b in a){
            foreach (object attribut in b)
            {
                Console.WriteLine($" - Attribut : {attribut.GetType().Name}");
            }
        }
        return View();
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
