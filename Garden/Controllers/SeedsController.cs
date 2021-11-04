using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Garden.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;


namespace Garden.Controllers
{
  public class SeedsController : Controller
  {
    // private readonly GardenContext _db;

    // public SeedsController(GardenContext db)
    // {
    //   _db = db;
    // }
    public IActionResult Index()
    {
      var seeds = Seed.Get();
      return View(seeds);
    }
    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Seed seed)
    {
      Seed.Post(seed);
      return RedirectToAction("Details", new {id = seed.SeedId});
    }


    public IActionResult Details(int id)
    {
      var model = Seed.GetDetails(id);
      return View(model);
    }


    public IActionResult Edit (int id)
    {
      var model = Seed.GetDetails(id);
      return View(model);
    }


    [HttpPost]
    public IActionResult Edit(int id, Seed seed)
    {
      seed.SeedId = id;
      Seed.Put(seed);
      return RedirectToAction("Details", new {id = seed.SeedId});
    }

    public IActionResult Delete(int id)
    {
      var model = Seed.GetDetails(id);
      return View(model);
    }


    public IActionResult DeleteConfirmed(int id)
    {
      Seed.Delete(id);
      return RedirectToAction("Index");
    }
  }
}

