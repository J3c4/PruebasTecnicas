using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebasTecnicas.Controllers
{
    public class RetosController : Controller
    {
        // GET: Retos
        public ActionResult Sencillos()
        {
            return View();
        }
    }
}
