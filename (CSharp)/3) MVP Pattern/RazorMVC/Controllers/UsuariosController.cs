using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorMVC.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Fernando");
            listaUsuarios.Add("Alejandra");
            listaUsuarios.Add("Raúl");
            listaUsuarios.Add("Martín");
            listaUsuarios.Add("Rodolfo");
            return View(listaUsuarios);
        }
    }
}