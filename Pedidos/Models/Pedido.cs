using Pedidos.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Pedido
    {
        public int id { get; set; }
        public int codProduto { get; set; }
        public int qtd { get; set; }
        public string obs { get; set; }
        public EstadoEnum estado { get; set; }
        public virtual Orcamento orcamento { get; set; }
        [NotMapped]
        public LinksPedido _links { get; set; }
    }
}
