using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppBancoDLL;
using AppBancoDominio;

namespace PalacePetz.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login(Login login)
        {
            if (login is null)
            {
                throw new ArgumentNullException(nameof(login));
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login( int id)
        {
            if (ModelState.IsValid)
            {
                var metodoFuncionario = new LoginDAO();
                metodoFuncionario.ListarId(id);
                return RedirectToAction(new { controller = "Inicio", action = "Index"});
            }
            return View();
        }

        private ActionResult RedirectToAction(object p)
        {
            throw new NotImplementedException();
        }
    }
}