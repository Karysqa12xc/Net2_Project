using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NetMVC.Models;

namespace NetMVC.Controllers;

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
    public IActionResult Index(string a, string b, string c)
    {
        double so1 = double.Parse(a);
        double so2 = double.Parse(b);
        double so3 = double.Parse(c);
        string Result = "";
        double delta = (so2 * so2) - (4 * so1 * so3);
        if (so1 == 0) Result = $"Phuong trinh co nghiem duy nhat la {-so3 / so2}";
        
        if (delta < 0)Result = "0";
        
        else if (delta == 0) Result = $"x1 = x2 = {-so2 / (2 * so1)}";
        else
        {
            double x1 = (-so2 + Math.Sqrt(delta)) / (2 * so1);
            double x2 = (-so2 - Math.Sqrt(delta)) / (2 * so1);
            Result = $"Nghiệm là x1 = {x1}, x2 = {x2}";
        }
        ViewBag.thongBao = Result;
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

