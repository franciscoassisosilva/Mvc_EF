using Mvc_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EF.Controllers
{
    public class TipoClienteController : Controller
    {
        //
        // GET: /Tipo/
        public ActionResult Index()
        {
            using(ClienteContext context = new ClienteContext())
            {
                List<TipoCliente> tipos = context.tipos.ToList();
                return View(tipos);
            }
        }
	}
}