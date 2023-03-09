using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project_Gradation.Models;

namespace Project_Gradation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()//餐廳首頁
    {
        
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Search()//搜尋
    {
        return View();
    }
    public IActionResult Kart()//購物車
    {
        return View();
    }
    public IActionResult Member()//會員
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
