using appIngles.Models;
using appIngles.Negocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace appIngles.Controllers
{
    public class PalabraController : Controller
    {
        // GET: PalabraController
        [HttpGet]
        public ActionResult Index()
        {
            string codError = "000";
            string menError = "";
            List<Palabra> listPalabra = new List<Palabra>();
            PalabraNeg negPalabra = new PalabraNeg();
            negPalabra.Buscar(1, ref listPalabra, ref codError, ref menError);

            return View(listPalabra.ToList());
        }

        // GET: PalabraController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PalabraController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PalabraController/Create
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

        // GET: PalabraController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PalabraController/Edit/5
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

        // GET: PalabraController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PalabraController/Delete/5
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
