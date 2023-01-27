using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SLNClinica.Data;

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
    }
}
