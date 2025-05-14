using CarVilla.Contexts;
using CarVilla.Models;
using CarVilla.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarVilla.Areas.Admin.Controllers;
[Area("Admin")]
public class FeaturedCarsController : Controller
{
    private readonly FeaturedCarService _service;
    public FeaturedCarsController()
    {
        _service = new FeaturedCarService();
    }

   
    #region Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Create(FeaturedCar featuredCar)
    {
        _service.CreateFeaturedCar(featuredCar);
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    #endregion
    #region Read

    [HttpGet]
    public IActionResult Index()
    {
        List<FeaturedCar> featuredCars = _service.GetAllFeatureCars();
        return View(featuredCars);
    }
    public IActionResult Info(int id)
    {
        FeaturedCar featuredCar = _service.GetFeaturedCarById(id);
        return View(featuredCar);
    }
    #endregion

    #region Update
    [HttpGet]
    public IActionResult Update(int id)
    {
       FeaturedCar car = _service.GetFeaturedCarById(id);
        return View(car);
    }
    [HttpPost]  
    public IActionResult Update(int id,FeaturedCar car)
    {

        return RedirectToAction(nameof(Index));
    }
    #endregion

    #region Delete
    [HttpGet]
    public IActionResult Delete(int id) 
    {
        FeaturedCar featured = _service.GetFeaturedCarById(id);
         return View(featured);
        //_service.DeleteFeaturedCar(id); 
        //return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ActionName("Delete")]
    public IActionResult DeletePost(int id)
    {

        _service.DeleteFeaturedCar(id);
        return RedirectToAction(nameof(Index));
    }

    #endregion
}
