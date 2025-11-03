using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Atendimento
{
    internal class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id { get => id; set => id = value; }
        internal Queue<Senha> Atendimentos { get => atendimentos; set => atendimentos = value; }

        public Guiche()
        {
            Atendimentos = new Queue<Senha>();
            Id = 0;
        }

        public Guiche(int id)
        {
            Id = id;
            Atendimentos = new Queue<Senha>();
        }

        public bool chamar(Queue<Senha> filaSenhas)
        {
            if(filaSenhas.Count == 0)
                return false;

            Senha proxima = filaSenhas.Dequeue();
            proxima.DataAtend = DateTime.Now;
            atendimentos.Enqueue(proxima);
            return true;
        } 

    }
}
