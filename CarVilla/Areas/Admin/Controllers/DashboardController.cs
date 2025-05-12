using CarVilla.Contexts;
using CarVilla.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVilla.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class DashboardController : Controller
	{
		private readonly AppDbContext _context;

		public DashboardController()
		{
			_context = new AppDbContext();

		}
		public IActionResult Index()
		{
			List<FeaturedCar> featuredCars = _context.FeaturedCars.ToList();
			return View();
		}
	}
}
