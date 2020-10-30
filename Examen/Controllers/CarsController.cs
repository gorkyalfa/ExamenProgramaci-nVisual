using Examen.Data;
using Examen.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Examen.Controllers
{
    public class CarsController : Controller
    {
        MainContext mainContext = new MainContext();

        public ActionResult Index()
        {
            var buses = mainContext.Cars.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car bus)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
