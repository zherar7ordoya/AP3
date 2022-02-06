using System.Linq;
using System.Web.Mvc;
using MVCEntityFramework.Models;

namespace MVCEntityFramework.Controllers
{
    public class EmpleadosController : Controller
    {
        public DeveloperEntitiesLAPTOP db = new DeveloperEntitiesLAPTOP();

        // GET: Empleados
        public ActionResult Index()
        {
            var empleados = db.Empleados.ToList();
            return View(empleados);
        }
    }
}