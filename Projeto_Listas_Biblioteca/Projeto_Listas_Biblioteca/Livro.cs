using System;
using System.Collections.Generic;

namespace Projeto_Listas_Biblioteca
{
    internal class Livro
    {
        public int Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public List<Exemplar> Exemplares { get; set; } = new List<Exemplar>();

        public Livro() { }

        public Livro(int isbn, string titulo, string autor, string editora)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
        }

        public void adicionarExemplar(Exemplar exemplar)
        {
            if (exemplar == null) return;
            Exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            return Exemplares.Count;
        }

        public int qtdeDisponiveis()
        {
            int cont = 0;
            foreach (Exemplar ex in Exemplares)
            {
                if (ex.disponivel())
                    cont++;
            }
            return cont;
        }

        public int qtdeEmprestimos()
        {
            int total = 0;
            foreach (Exemplar ex in Exemplares)
            {
                total += ex.qtdeEmprestimos();
            }
            return total;
        }

        public double percDisponibilidade()
        {
            int total = qtdeExemplares();
            if (total == 0) return 0.0;
            return ((double)qtdeDisponiveis() / total) * 100.0;
        }

        public override string ToString()
        {
            return $"{Titulo} (ISBN {Isbn}) - Total: {qtdeExemplares()}, Disponíveis: {qtdeDisponiveis()}, Empr.: {qtdeEmprestimos()}, %Disp: {percDisponibilidade():0.##}%";
        }
    }
}
