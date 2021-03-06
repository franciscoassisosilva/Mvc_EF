﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc_EF.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        [ForeignKey("Tipo")]
        public int TipoId { get; set; }

        public TipoCliente Tipo { get; set; }
    }
}