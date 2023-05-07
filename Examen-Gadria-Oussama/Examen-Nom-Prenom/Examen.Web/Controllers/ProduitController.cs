using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Examen.ApplicationCore.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;
using Examen.ApplicationCore.Services;

namespace Examen.Web.Controllers
{
    public class ProduitController : Controller
    {
        IProduit p;
        ICategorie c;

        public ProduitController(IProduit p, ICategorie c)
        {
            this.p = p;
            this.c = c;
        }



        // GET: ProduitController
        public ActionResult Index()
        {
            return View(p.GetAll());
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            ViewBag.CategorieList = new SelectList(c.GetAll(), "Id", "Nom");
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produit produit)
        {
            try
            {
                p.Add(produit);
                p.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitController/Edit/5
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

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
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
        [HttpPost]
        public IActionResult Index(string searchString)
        {
            var produits = p.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                produits = produits.Where(p => p.Nom.Contains(searchString));
            }
            return View(produits);
        }
    }
}
