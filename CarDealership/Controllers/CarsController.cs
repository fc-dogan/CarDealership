using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
    public class CarsController : Controller
    {

      [HttpGet("/cars")]
      public ActionResult Index()
      {
        Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, "This car is red, with a rustic feel.");
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, "This car is blue, making you feel like you are flying.");
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, "This car is green like driving in the forest.");
      Car amc = new Car("1976 AMC Pacer", 400, 198000, "This car is pink just like Barbie.");
        List<Car> allCars = Car.GetAll();
        return View(allCars);
      }

      [HttpGet("/cars/new")]
      public ActionResult CreateForm()
      {
        return View();
      }

      [HttpPost("/cars")]
      public ActionResult Create(string makeModel, int price, int miles, string info)
      {
        Car newCar = new Car(makeModel, price, miles, info);
        
        return RedirectToAction("Index");
      }

    }
}