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
  public class PlotsController : Controller
  {
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly GardenContext _db;

    public PlotsController(UserManager<ApplicationUser> userManager, GardenContext db)
    {
      _userManager = userManager;
      _db = db;
    }
    [AllowAnonymous]
    public ActionResult Index()
    {
      List<Plot> model = _db.Plots.ToList();
      return View(model);
    }
    [Authorize]
    public async Task<ActionResult> Create()
    {
      // ViewBag.PlotId = new SelectList(_db.Plots, "PlotId", "PlotName");
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userItems = _db.Plots.Where(entry => entry.User.Id == currentUser.Id).ToList();
      return View();
    }

    [HttpPost]
    public ActionResult Create(Plot plot)
    {
      _db.Plots.Add(plot);
      _db.SaveChanges();
      return RedirectToAction("Details", new {id = plot.PlotId});
    }

    public ActionResult Details(int id)
    {
      var thisPlot = _db.Plots.FirstOrDefault(model => model.PlotId == id);
      int zipcode = thisPlot.ZipCode;
      ViewBag.thisZipZone = ZipZone.Get(zipcode);

      return View(thisPlot);
    }

    [Authorize]
    public ActionResult Edit(int id)
    {
      var thisPlot = _db.Plots.FirstOrDefault(plot => plot.PlotId == id);
      return View(thisPlot);
    }

    [HttpPost]
    public ActionResult Edit(Plot plot)
    {
      _db.Entry(plot).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [Authorize]
    public ActionResult Delete(int id)
    {
      var thisPlot = _db.Plots.FirstOrDefault(plot => plot.PlotId == id);
      return View(thisPlot);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisPlot = _db.Plots.FirstOrDefault(plot => plot.PlotId == id);
      _db.Plots.Remove(thisPlot);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}