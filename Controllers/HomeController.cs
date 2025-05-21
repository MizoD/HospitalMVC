using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HospitalMVC.Models;
using Microsoft.EntityFrameworkCore;
using HospitalMVC.Data;

namespace HospitalMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDBContext _context = new();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Booking()
    {
        var Doctors = _context.Doctors;
        return View(Doctors.ToList());
    }
    public IActionResult BookingForm()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
