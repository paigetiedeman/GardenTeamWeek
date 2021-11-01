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
  
  public class SquarefootsController : Controller
  {
    private readonly GardenContext _db;

    public SquarefootsController(GardenContext db)
    {
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Squarefoot> model = _db.Squarefoots.ToList();
      return View(model);
    }
    [Authorize]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Squarefoot squarefoot)
    {
      _db.Squarefoots.Add(squarefoot);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisSquarefoot = _db.Squarefoots;
      return View(thisSquarefoot);
    }
    [Authorize]
    public ActionResult Edit(int id)
    {
      var thisSquarefoot = _db.Squarefoots.FirstOrDefault(squarefoot => squarefoot.SquarefootId == id);
      return View(thisSquarefoot);
    }

    [HttpPost]
    public ActionResult Edit(Squarefoot squarefoot)
    {
      _db.Entry(squarefoot).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [Authorize]
    public ActionResult Delete(int id)
    {
      var thisSquarefoot = _db.Squarefoots.FirstOrDefault(squarefoot => squarefoot.SquarefootId == id);
      return View(thisSquarefoot);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSquarefoot = _db.Squarefoots.FirstOrDefault(squarefoot => squarefoot.SquarefootId == id);
      _db.Squarefoots.Remove(thisSquarefoot);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}