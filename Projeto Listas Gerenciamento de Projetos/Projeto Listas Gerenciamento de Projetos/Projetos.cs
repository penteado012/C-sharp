using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Projetos
    {
        private List<Projeto> itens = new List<Projeto>();
        public List<Projeto> Itens { get => itens; set => itens = value; }

        public bool Adicionar(Projeto p)
        {
            if (p == null) return false;

            // evitar duplicata por id
            if (itens.Any(x => x.Id == p.Id))
                return false;

            itens.Add(p);
            return true;
        }

        public bool Remover(Projeto p)
        {
            return itens.Remove(p);
        }

        public Projeto Buscar(Projeto p)
        {
            if (p == null) return null;
            return itens.FirstOrDefault(x => x.Id == p.Id);
        }

        public List<Projeto> Listar()
        {
            return new List<Projeto>(itens);
        }

        // opcional: buscar por id diretamente
        public Projeto BuscarPorId(int id)
        {
            return itens.FirstOrDefault(x => x != null && x.Id == id);
        }
    }
}
