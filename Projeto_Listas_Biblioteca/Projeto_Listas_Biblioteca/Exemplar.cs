using System;
using System.Collections.Generic;

namespace Projeto_Listas_Biblioteca
{
    internal class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        public Exemplar(int tombo)
        {
            this.tombo = tombo;
        }

        public bool disponivel()
        {
            if (emprestimos.Count == 0) return true;
            Emprestimo ultimo = emprestimos[emprestimos.Count - 1];
            return ultimo.dtDevolucao != DateTime.MinValue;
        }

        public bool emprestar()
        {
            if (!disponivel()) return false;
            Emprestimo e = new Emprestimo
            {
                dtEmprestimo = DateTime.Now,
                dtDevolucao = DateTime.MinValue
            };
            emprestimos.Add(e);
            return true;
        }

        public bool devolver()
        {
            if (disponivel()) return false;
            Emprestimo ultimo = emprestimos[emprestimos.Count - 1];
            ultimo.dtDevolucao = DateTime.Now;
            return true;
        }

        public int qtdeEmprestimos()
        {
            return emprestimos.Count;
        }

        public override string ToString()
        {
            return $"Tombo: {tombo}, Empr.: {qtdeEmprestimos()}, Disponível: {disponivel()}";
        }
    }
}
