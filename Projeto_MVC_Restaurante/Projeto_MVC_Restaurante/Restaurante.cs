using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Restaurante
{
    internal class Restaurante
    {
        private static int proxPedido = 1;
        private Pedido[] pedidos = new Pedido[50];
        public Pedido[] Pedidos { get => pedidos;}

        public bool novoPedido(Pedido pedido)
        {
            for(int i = 0; i < this.Pedidos.Length; i++)
            {
                if (Pedidos[i] == null)
                {
                    Pedidos[i] = pedido;
                    Pedidos[i].Id = proxPedido++;
                    return true;
                }
            }
            return false;
        }

        public Pedido buscarPedido (Pedido pedido)
        {
            foreach (var p in Pedidos)
            {
                if (p != null && p.Id == pedido.Id)
                {
                    return p;
                }
            }
            return null;
        }

        public bool cancelarPedido(Pedido pedido)
        {
            for(int i = 0; i < Pedidos.Length; i++)
            {
                if (Pedidos[i] != null && Pedidos[i].Id == pedido.Id)
                {
                    for(int j = i; j < Pedidos.Length - 1; j++)
                    {
                        Pedidos[j] = Pedidos[j + 1];
                    }
                    Pedidos[Pedidos.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
