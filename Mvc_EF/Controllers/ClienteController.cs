using Mvc_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_EF.Controllers
{
    public class ClienteController : Controller
    {
        //
        // GET: /Cliente/
        public ActionResult Index()
        {
            ClienteContext cc = new ClienteContext();
            List<Cliente> lista = cc.clientes.ToList();            
            return View(lista);
        }
	}
}