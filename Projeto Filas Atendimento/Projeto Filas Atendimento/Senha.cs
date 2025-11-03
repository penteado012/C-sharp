using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Atendimento
{
    internal class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime dataAtend;

        public Senha(int id)
        {
            this.Id = id;
            this.dataGerac = DateTime.Now;
        }

        
        public DateTime DataGerac { get => dataGerac; set => dataGerac = value; }
        public int Id { get => id; set => id = value; }
        public DateTime DataAtend { get => dataAtend; set => dataAtend = value; }

        public string dadosParciais()
        {
            return Id + "-" + DataGerac;
        }

        public string dadosCompletos()
        {
            return Id + "-" + DataGerac + "----" + DataAtend;
        }
}
}
