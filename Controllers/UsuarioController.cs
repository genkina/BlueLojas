using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using blueLojas.Models;
using Microsoft.AspNetCore.Http;

namespace blueLojas.Controllers
{
    public class UsuarioController : Controller
    {

        private static Usuario _usuarios = new Usuario();

        public ActionResult Index()
        {
            return View(_usuarios.listaUsuarios);
        }

        public ActionResult AdicionaUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdicionaUsuario(UsuarioModel _usuarioModel)
        {
            _usuarios.CriaUsuario(_usuarioModel);
            return View();
        }
        public ViewResult DeletaUsuario(string id)
        {
            return View(_usuarios.GetUsuario(id));

        }
    }
}
