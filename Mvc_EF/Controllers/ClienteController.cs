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
        public ActionResult Index(int tipoId)
        {            
            using (ClienteContext cc = new ClienteContext()) {
                List<Cliente> lista = new List<Cliente>();
                lista = cc.clientes.Where(c=>c.TipoId == tipoId).ToList();
                
                return View(lista);
            }
        }

        public ActionResult Detalhes(int id)
        {            
            using (ClienteContext cc = new ClienteContext())
            {   
                Cliente cliente = cc.clientes.Include("Tipo").SingleOrDefault(c=>c.Id == id);
                return View(cliente);
            }            
        }
	}
}