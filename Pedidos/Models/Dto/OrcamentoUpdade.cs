using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Models.Dto
{
    public class OrcamentoUpdade
    {
        public decimal valor { get; set; }
        public string dataEntrega { get; set; }
        public bool aceita { get; set; }
    }
}
