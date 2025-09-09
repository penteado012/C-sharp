using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Restaurante
{
    internal class Pedido
    {
        private static int ContatorIdItem = 1;
        private int id;
        private string cliente;
        private Item[] items = new Item[10];
        public int Id { get => id; set => id = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public Item[] Items { get => items; set => items = value; }

        public bool adcionarItem(Item item)
        {
            for(int i = 0; i < this.items.Length; i++)
            {
                if (this.Items[i] == null)
                {
                    this.Items[i] = item;
                    this.Items[i].Id = ContatorIdItem++;
                    return true;
                }
            }
            return false;
        }

        public bool removerItem(Item item)
        {
            for(int i = 0; i < this.Items.Length; i++)
            {
                if(this.Items[i]!= null && this.Items[i].Id == item.Id)
                {
                    for(int j = i; j < this.Items.Length -1; j++)
                    {
                        Items[j] = items[j + 1];
                    }
                    Items[Items.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }

        public string dadosDoPedido()
        {
            int contador = 1;
            bool temitem = false;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id do pedido: " + this.Id);
            sb.AppendLine("Nome do Cliente: " + this.Cliente);

            foreach(Item item in this.Items)
            {
                if(item != null)
                {
                    temitem = true;
                    sb.AppendLine("Item " + contador++ + ": ");
                    sb.AppendLine("Id: " + item.Id);
                    sb.AppendLine("Descrição: " + item.Descricao);
                    sb.AppendLine("Preço: R$" + item.Preco.ToString("F2"));
                }
            }
            if (!temitem)
            {
                sb.AppendLine("Não tem item nesse pedido!");
            }
            sb.AppendLine("Valor total do pedido: R$" + calcularTotal().ToString("F2"));
            return sb.ToString();
        }

        public double calcularTotal()
        {
            double total = 0;
            foreach(Item item in this.Items)
            {
                if(item != null)
                {
                    total += item.Preco;
                }
            }
            return total;
        }

    }
}
