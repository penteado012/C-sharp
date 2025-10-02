using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Biblioteca
{
    internal class Livros
    {
        private List<Livro> acervo = new List<Livro>();

        public void adicionar(Livro livro)
        {
            acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {
            foreach (Livro l in acervo)
            {
                if (l.Isbn == livro.Isbn)
                {
                    return l;
                }
            }
            return null;
        }

        public Livro pesquisar(int isbn)
        {
            foreach (Livro l in acervo)
            {
                if (l.Isbn == isbn)
                {
                    return l;
                }
            }
            return null;
        }
    }
}
