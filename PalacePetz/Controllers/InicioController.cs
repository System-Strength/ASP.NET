﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PalacePetz.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult VerificaGer()
        {
            return View();
        }
        public ActionResult CadastrarFunc()
        {
            return View();
        }
    }
}