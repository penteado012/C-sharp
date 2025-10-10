using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Projeto
    {
        private int id;
        private string nome;
        private List<Tarefa>tarefas = new List<Tarefa>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public List<Tarefa> Tarefas { get => tarefas; set => tarefas = value; }
        
        public void AdicionarTarefa(Tarefa t)
        {
            if (t != null)
            {
                tarefas.Add(t);
                Console.WriteLine("Tarefa Adicionada com sucesso!");
            } else
            {
                Console.WriteLine("Não foi possível adicionar uma tarefa");
            }
        }

        public bool removerTarefa(Tarefa t)
        {
            if (t != null)
            {
                tarefas.Remove(t);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Tarefa buscarTarefa(Tarefa t)
        {
            if (tarefas.Contains(t))
            {
                return t;
            }
            else
            {
                return null;
            }
        }

        public List<Tarefa> tarefasPorStatus(string s)
        {
            List<Tarefa> resultado = new List<Tarefa>();
            foreach (Tarefa t in tarefas) 
            {
                if (t.Status == s)
                {
                    resultado.Add(t);
                }
            }
            return resultado;
        }

        public List<Tarefa> tarefasPorPrioridade(int p)
        {
            List<Tarefa> resultado = new List<Tarefa>(); 
            foreach(Tarefa t in tarefas)
            {
                if (t.Id == p)
                {
                    resultado.Add(t);
                }
            }
            return resultado;
        }

        
    }
}
