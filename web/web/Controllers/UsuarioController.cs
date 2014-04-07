using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

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
            return new EmptyResult();
        }

    }
}
