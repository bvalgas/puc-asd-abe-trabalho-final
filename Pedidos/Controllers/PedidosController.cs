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
            WebRequest request = WebRequest.Create("http://localhost/api/notificacoes/v1/pedido-cadastrado");
            request.Credentials = CredentialCache.DefaultCredentials;
            
            WebResponse response = await request.GetResponseAsync();
            return new JsonResult(novoPedido);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(_context.Pedidos.SingleOrDefault(x => x.id == id));
        }

        [HttpPut("{id}")]
        public JsonResult Put(int id, [FromBody]OrcamentoUpdade orcamento)
        {
            var pedido = _context.Pedidos.SingleOrDefault(x => x.id == id);
            if(pedido != null)
            {
                pedido.orcamento = new Orcamento { aceita = orcamento.aceita, dataEntrega = orcamento.dataEntrega, valor = orcamento.valor };
                _context.SaveChanges();
                return new JsonResult(pedido.orcamento);
            }
            return null;

        }
    }
}
