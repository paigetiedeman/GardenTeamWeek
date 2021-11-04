using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Garden.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


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

    // [HttpPost]
    // public ActionResult Create(Seed seed)
    // {
    //   _db.Seeds.Add(seed);
    //   _db.SaveChanges();
    //   return RedirectToAction("Details");
    // }

    public IActionResult Details(int id)
    {
      var model = Seed.GetDetails(id);
      return View(model);
    }

    // public ActionResult Edit(int id)
    // {
    //   var thisSeed = _db.Seeds.FirstOrDefault(seed => seed.SeedId == id);
    //   return View(thisSeed);
    // }

    // [HttpPost]
    // public ActionResult Edit(Seed seed)
    // {
    //   _db.Entry(seed).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
    // public ActionResult Delete(int id)
    // {
    //   var thisSeed = _db.Seeds.FirstOrDefault(seed => seed.SeedId == id);
    //   return View(thisSeed);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisSeed = _db.Seeds.FirstOrDefault(seed => seed.SeedId == id);
    //   _db.Seeds.Remove(thisSeed);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}