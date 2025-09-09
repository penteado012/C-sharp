using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Restaurante
{
    internal class Item
    {
        private static int contadorId = 1;
        private int id;
        private string descricao;
        private double preco;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }
    }
}
