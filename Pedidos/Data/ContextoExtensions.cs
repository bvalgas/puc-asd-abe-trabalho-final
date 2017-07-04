using Pedidos.Models;
using Pedidos.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Data
{
    public static class ContextoExtensions
    {
        public static void InitializeData(this Contexto context)
        {
            IncluirPedido(context, 1, 5, 10, "observação 5", EstadoEnum.Solicitado, new LinksPedido { orcamento = "", produto = "", self = "" });
            IncluirPedido(context, 2, 6, 14, "observação 4", EstadoEnum.EmFabricacao, new LinksPedido { orcamento = "", produto = "", self = "" });
            IncluirPedido(context, 3, 7, 12, "observação 3", EstadoEnum.Despachado, new LinksPedido { orcamento = "", produto = "", self = "" });
            IncluirPedido(context, 4, 8, 18, "observação 2", EstadoEnum.Solicitado, new LinksPedido { orcamento = "", produto = "", self = "" });
            IncluirPedido(context, 5, 9, 9, "", EstadoEnum.Finalizado, new LinksPedido { orcamento = "", produto = "", self = "" });

            context.SaveChanges();
        }

        private static void IncluirPedido(
            Contexto context,
            int id, int codproduto, int quantidade, string obs, EstadoEnum estado, LinksPedido links)
        {
            context.Pedidos.Add(
                new Pedido()
                {
                    id = id,
                    codProduto = codproduto,
                    estado = estado,
                    obs = obs,
                    qtd = quantidade,
                    _links = links
                });
        }
    }
}
