using CarVilla.Contexts;
using CarVilla.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarVilla.Controllers;

[Area("Admin")]

public class FeaturedCarsController : Controller
{
	private readonly AppDbContext _context;

	public FeaturedCarsController()
	{
		_context = new AppDbContext();
	}

	[HttpGet]
	public IActionResult Index()
	{

		List<FeaturedCar> featuredCars = _context.FeaturedCars.ToList();
		return View();
	}
	[HttpGet]
	public IActionResult Create()
	{
		return View();
	}



	[HttpPost]
	public IActionResult Create(FeaturedCar featuredCar)
	{
		return View(featuredCar);
	}
}
