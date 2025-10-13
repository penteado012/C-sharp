using System;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Tarefa
    {
        private int id;
        private string titulo;
        private string descricao;
        private int prioridade;
        private string status;
        private DateTime dataCriacao;
        private DateTime dataConclusao;
        private static int contador = 1;

        public int Id { get => id; private set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Prioridade { get => prioridade; set => prioridade = value; }
        public string Status { get => status; set => status = value; }
        public DateTime DataCriacao { get => dataCriacao; set => dataCriacao = value; }
        public DateTime DataConclusao { get => dataConclusao; set => dataConclusao = value; }

        public Tarefa(string titulo, string descricao, int prioridade)
        {
            this.Id = contador++;
            this.Titulo = titulo ?? "";
            this.Descricao = descricao ?? "";
            this.Prioridade = prioridade;
            this.Status = "Aberta";
            this.DataCriacao = DateTime.Now;
            this.DataConclusao = DateTime.MinValue; // sem conclusão ainda
        }

        public void Concluir()
        {
            if (!string.IsNullOrEmpty(Status) && Status.Equals("Fechada", StringComparison.OrdinalIgnoreCase))
                return; // já fechada

            if (!string.IsNullOrEmpty(Status) && Status.Equals("Cancelada", StringComparison.OrdinalIgnoreCase))
                return; // não concluímos canceladas

            Status = "Fechada";
            DataConclusao = DateTime.Now;
        }

        public void Cancelar()
        {
            if (!string.IsNullOrEmpty(Status) && Status.Equals("Fechada", StringComparison.OrdinalIgnoreCase))
                return; // não cancelar já fechada

            Status = "Cancelada";
            DataConclusao = DateTime.Now;
        }

        public void Reabrir()
        {
            if (Status == null || Status.Equals("Aberta", StringComparison.OrdinalIgnoreCase))
                return;

            Status = "Aberta";
            DataConclusao = DateTime.MinValue;
        }
    }
}
