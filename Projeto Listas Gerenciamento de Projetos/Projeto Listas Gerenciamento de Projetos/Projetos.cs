using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Projetos
    {
       private List<Projeto> itens = new List<Projeto>();
       public List<Projeto> Itens { get => itens; set => itens = value; }

       public bool adicionar(Projeto p)
       {
            if (p != null)
            {
                Itens.Add(p);
                return true;
            }
            else
            {
                return false;
            }
       }

       public bool remover(Projeto p)
       {
            if (Itens.Remove(p))
            {
                return true;
            }
            else
            {
                return false;
            }
       }

        public Projeto buscar(Projeto p)
        {
            foreach (Projeto pj in itens)
            {
                if (pj.Equals(p))
                {
                    return pj;
                }
            }
            return null;
        }

        public List<Projeto> listar()
        {
            return new List<Projeto>(itens);
        }
    }
}
