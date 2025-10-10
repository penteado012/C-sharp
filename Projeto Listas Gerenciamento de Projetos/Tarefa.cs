using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Tarefa
    {
        private int id;
        private string titulo;
        private string descricao;
        private int prioridade;
        private string status;
        private DateTime datacriacao;
        private DateTime dataConclusao;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => Titulo; set => Titulo = value; }
        public string Descricao { get => descricao; set => descricao = value ; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public string Status { get => status; set => status = value; }
        public DateTime DataCriacao {get => datacriacao; set => datacriacao = value; }
        public DateTime DataConclusao { get => dataConclusao; set => dataConclusao = value; }

        public void concluir()
        {
            Status = "Fechada";
            DataConclusao = DateTime.Now;
        }

        public void cancelar()
        {
            Status = "Cancelada";
            DataConclusao = DateTime.Now;
        }

        public void reabrir()
        {
            if (Status != "Aberta")
            {
                Status = "Aberta";
                DataConclusao = DateTime.MinValue;
            }
        }
    }
}
