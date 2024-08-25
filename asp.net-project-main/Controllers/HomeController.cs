using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using asp.net_project_main.Models;
using asp.net_project_main.Data;
using Microsoft.EntityFrameworkCore;

namespace asp.net_project_main.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    protected readonly aspnet_project_mainContext _context;

    public HomeController(ILogger<HomeController> logger, aspnet_project_mainContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var asp_data_product = _context.Product.Include(p => p.Category);

        return View(await asp_data_product.ToListAsync());
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
    public async Task<IActionResult> Details(int? id)
    {
		if (id == null)
		{
			return NotFound();
		}

		var aspnetProduct = await _context.Product.FirstOrDefaultAsync(p => p.Id == id);
		if (aspnetProduct == null)
		{
			return NotFound();
		}

		return View(aspnetProduct);
	} 
    public IActionResult Product()
    {
        return View();
    }
}

