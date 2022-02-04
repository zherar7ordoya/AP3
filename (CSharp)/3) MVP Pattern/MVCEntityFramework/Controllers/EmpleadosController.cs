using System.Linq;
using System.Web.Mvc;
using MVCEntityFramework.Models;

namespace MVCEntityFramework.Controllers
{
    public class EmpleadosController : Controller
    {
        public DeveloperEntities db = new DeveloperEntities();

        // GET: Empleados
        public ActionResult Index()
        {
            var empleados = db.Empleados.ToList();
            return View(empleados);
        }
    }
}