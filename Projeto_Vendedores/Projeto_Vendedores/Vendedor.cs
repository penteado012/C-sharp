using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendedores
{
    internal class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda []asVendas = new Venda[31];

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public double PercComissao { get => percComissao; set => percComissao = value; }
        public Venda[] AsVendas { get => asVendas;}

        public void registrarVenda(int dia, Venda venda) 
        {
            asVendas[dia] = venda;
        }
        public double valorVendas() 
        {
            double total = 0;
            for (int i = 0; i < asVendas.Length; i++) 
            {
                if (asVendas[i] != null) 
                {
                    total += asVendas[i].Valor;
                }
            }
            return total;
        }

        public double valorComissao() 
        {
            return valorVendas() * percComissao / 100;
        }

        public string dadosVendedor()
        {
            return "Nome: " + Nome + "\n" +
                   "Id: " + Id + "\n" +
                   "Porcentagem de Comissão: " + PercComissao + "%\n"+
                   "Valor total de vendas: " + valorVendas() + "\n" +
                   "Valor total de Comissão: " + valorComissao() + "\n" ;
        }
    }
}
