using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Orcamento
    {
        public int id { get; set; }
        public decimal valor { get; set; }
        public string dataEntrega { get; set; }
        public bool aceita { get; set; }
        [NotMapped]
        public LinksOrcamento _links { get; set; }
    }
}
