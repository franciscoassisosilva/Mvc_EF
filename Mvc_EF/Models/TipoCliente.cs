using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    [Table("Tipos")]
    public class TipoCliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        
        public IList<Cliente> clientes { get; set; }
    }
}