using DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;


namespace BitStorm.Controllers;

public class HomeController : Controller
{
    //private readonly ILogger<HomeController> _logger;

    private readonly IUnitOfWork _unitOfWork;
    public HomeController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    //public HomeController(IUnitOfWork unitOfWork)
    //{
    //    _logger = logger;
    //}

    public IActionResult Index()
    {
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
