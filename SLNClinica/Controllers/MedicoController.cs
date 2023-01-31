using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SLNClinica.Data;
using SLNClinica.Models;

namespace SLNClinica.Controllers
{
    public class MedicoController : Controller
    {
        private readonly DBClinicaMVC context;
        public MedicoController(DBClinicaMVC context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var medico = context.Medicos.ToList();
            return View(medico);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Medico medico = new Medico();

            return View("Create", medico);
        }

        //post: Opera/Create
        [HttpPost]
        public ActionResult Create(Medico medico)
        {
            if (ModelState.IsValid)
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medico);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Medico medico = TraerUna(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", medico);
            }
        }

        private Medico TraerUna(int id)
        {
            return context.Medicos.Find(id);
        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var medico = TraerUna(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", medico);
            }

        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Medico medico = TraerUna(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                context.Medicos.Remove(medico);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", medico);
            }
        }


        [ActionName("Edit")]
        [HttpPost]
        public ActionResult EditConfirmed(Medico medico)
        {

            context.Entry(medico).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
