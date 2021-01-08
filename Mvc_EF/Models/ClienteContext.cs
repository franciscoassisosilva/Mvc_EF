using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() 
            : base("ClienteContext")

        {
            Database.SetInitializer<ClienteContext>(null);// desabilitar a criação do banco.
        }

        public DbSet<Cliente> clientes { get; set; }
        public DbSet<TipoCliente> tipos { get; set; }
    }
}