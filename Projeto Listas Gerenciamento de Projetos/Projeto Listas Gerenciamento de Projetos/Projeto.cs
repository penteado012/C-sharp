using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Projeto
    {
        private static int nextId = 1;

        private int id;
        private string nome;
        private List<Tarefa> tarefas = new List<Tarefa>();

        public int Id { get => id; private set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Tarefa> Tarefas { get => tarefas; set => tarefas = value; }

        // construtor para criar novo projeto (gera id automaticamente)
        public Projeto(string nome1)
        {
            this.Id = nextId++;
            this.Nome = nome1 ?? "";
            this.tarefas = new List<Tarefa>();
        }

        // construtor auxiliar para busca por id
        public Projeto(int idPesquisa)
        {
            this.Id = idPesquisa;
            this.tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(Tarefa t)
        {
            if (t != null)
            {
                tarefas.Add(t);
                Console.WriteLine("Tarefa adicionada com sucesso!");
            }
            else
            {
                Console.WriteLine("ERRO!!! Não foi possível adicionar a tarefa.");
            }
        }

        public bool RemoverTarefa(Tarefa t)
        {
            return tarefas.Remove(t);
        }

        // buscar tarefa por id
        public Tarefa BuscarTarefaPorId(int idTarefa)
        {
            return tarefas.FirstOrDefault(t => t != null && t.Id == idTarefa);
        }

        public List<Tarefa> TarefasPorStatus(string s)
        {
            List<Tarefa> resultado = new List<Tarefa>();
            if (string.IsNullOrEmpty(s)) return resultado;

            foreach (Tarefa t in tarefas)
            {
                if (t != null && !string.IsNullOrEmpty(t.Status) &&
                    t.Status.Equals(s, StringComparison.OrdinalIgnoreCase))
                {
                    resultado.Add(t);
                }
            }
            return resultado;
        }

        public List<Tarefa> TarefasPorPrioridade(int p)
        {
            List<Tarefa> resultado = new List<Tarefa>();
            foreach (Tarefa t in tarefas)
            {
                if (t != null && t.Prioridade == p)
                {
                    resultado.Add(t);
                }
            }
            return resultado;
        }

        public int TotalAbertas()
        {
            int quant = 0;
            foreach (Tarefa t in tarefas)
            {
                if (t != null && !string.IsNullOrEmpty(t.Status) &&
                    t.Status.Equals("Aberta", StringComparison.OrdinalIgnoreCase))
                {
                    quant++;
                }
            }
            return quant;
        }

        public int TotalFechadas()
        {
            int quant = 0;
            foreach (Tarefa t in tarefas)
            {
                if (t != null && !string.IsNullOrEmpty(t.Status) &&
                    t.Status.Equals("Fechada", StringComparison.OrdinalIgnoreCase))
                {
                    quant++;
                }
            }
            return quant;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            Projeto outro = (Projeto)obj;
            return this.Id == outro.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
