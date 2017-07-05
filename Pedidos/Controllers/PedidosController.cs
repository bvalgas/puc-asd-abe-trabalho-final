using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pedidos.Data;
using Pedidos.Models;
using Pedidos.Models.Dto;
using System.Net;

namespace Pedidos.Controllers
{
    [Route("api/pedidos/v1/[controller]")]
    public class PedidosController : Controller
    {
        private Contexto _context;

        public PedidosController(Contexto context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<JsonResult> PostAsync([FromBody]PedidoCreate pedido)
        {
            var novoPedido = new Pedido { codProduto = pedido.codProduto, qtd = pedido.qtd, obs = pedido.obs };
       
            _context.Pedidos.Add(novoPedido);
            _context.SaveChanges();
            novoPedido = _context.Pedidos.Single(x => x.id == novoPedido.id);
            novoPedido._links = new LinksPedido { self = "http://localhost:5000/api/pedidos/v1/Pedidos/" + novoPedido.id,
            orcamento = "http://localhost:5000/api/pedidos/v1/Pedidos/" + novoPedido.id + "/orcamento",
            produto = "http://localhost:8090/api/produtos/v1/produtos/"+ novoPedido.codProduto
            };
            _context.SaveChanges();
            
            return new JsonResult(novoPedido);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var pedido = _context.Pedidos.SingleOrDefault(x => x.id == id);
            if(pedido != null)
            {
                pedido._links = new LinksPedido
                {
                    self = "http://localhost:5000/api/pedidos/v1/Pedidos/" + pedido.id,
                    orcamento = "http://localhost:5000/api/pedidos/v1/Pedidos/" + pedido.id + "/orcamento",
                    produto = "http://localhost:8090/api/produtos/v1/produtos/" + pedido.codProduto
                };
            }
            return new JsonResult(pedido);
        }

        [HttpPut("{id}/orcamento")]
        public JsonResult Put(int id, [FromBody]OrcamentoUpdade orcamento)
        {
            var pedido = _context.Pedidos.SingleOrDefault(x => x.id == id);
            if(pedido != null)
            {
                pedido.orcamento = new Orcamento { aceita = orcamento.aceita, dataEntrega = orcamento.dataEntrega, valor = orcamento.valor };
                _context.SaveChanges();
                pedido.orcamento._links = new LinksOrcamento { pedido = "http://localhost:5000/api/pedidos/v1/Pedidos/" + pedido.id,
                self = "http://localhost:5000/api/pedidos/v1/Pedidos/" + pedido.id + "/orcamento",
                };
                _context.SaveChanges();

                return new JsonResult(pedido.orcamento);
            }
            return null;

        }
    }
}
