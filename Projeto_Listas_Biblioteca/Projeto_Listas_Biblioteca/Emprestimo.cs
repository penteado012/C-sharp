using System;

namespace Projeto_Listas_Biblioteca
{
    internal class Emprestimo
    {
        public DateTime dtEmprestimo { get; set; }
        public DateTime dtDevolucao { get; set; } = DateTime.MinValue;

        public Emprestimo() { }

        public override string ToString()
        {
            string dev = (dtDevolucao == DateTime.MinValue) ? "Ainda não devolvido" : dtDevolucao.ToString();
            return $"Emprestado: {dtEmprestimo} | Devolução: {dev}";
        }
    }
}
