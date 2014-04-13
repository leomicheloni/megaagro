using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;
using web.services;

namespace web.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/
        UsuarioService usuarioService = new UsuarioService();

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// La vista envía los datos para intentar logear al usuario
        /// </summary>
        /// <returns></returns>
        public ActionResult Login(LoginUserViewModel loginUser)
        {
            usuarioService.Login(new model.Usuario { Email = loginUser.Email, Contrasena = loginUser.Password });
            return new EmptyResult();
        }


   }
}
