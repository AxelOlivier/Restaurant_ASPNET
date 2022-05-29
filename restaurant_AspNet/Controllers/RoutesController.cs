using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestoApi.Controllers
{
    public class RoutesController : Controller
    {
        // GET: RoutesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoutesController/Details/id
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoutesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoutesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RoutesController/Edit/id
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoutesController/Edit/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: RoutesController/Delete/id
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoutesController/Delete/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
