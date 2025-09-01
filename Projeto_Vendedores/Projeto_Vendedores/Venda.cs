using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendedores
{
    internal class Venda
    {
        private int qtde;
        private double valor;

        public int Qtde { get => qtde; set => qtde = value; }
        public double Valor { get => valor; set => valor = value; }

        public Venda(int Qtde, double Valor) 
        { 
            this.valor = Valor;
            this.qtde = Qtde;
        }


        public double valorMedio()
        {
        return valor / qtde;
        }
    }
}
