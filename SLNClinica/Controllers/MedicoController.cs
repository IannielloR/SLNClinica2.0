using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
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
    }
}
