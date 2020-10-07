using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProvaWEB.Context;
using ProvaWEB.Models;

namespace ProvaWEB.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Professor
        public ActionResult Index()
        {
            return View(db.professor.ToList());
        }

        // Cadastro
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(ProfessorModel professorModel)
        {
            if (ModelState.IsValid)
            {
                db.professor.Add(professorModel);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(professorModel);
        }
    }
}