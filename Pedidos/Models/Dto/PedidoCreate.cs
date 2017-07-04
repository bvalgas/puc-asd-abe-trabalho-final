using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models.Dto
{
    public class PedidoCreate
    {
        public int codProduto { get; set; }
        public int qtd { get; set; }
        public string obs { get; set; }
    }
}
