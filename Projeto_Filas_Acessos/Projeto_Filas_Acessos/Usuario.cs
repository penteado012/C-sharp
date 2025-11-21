using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Acessos
{
    internal class Usuario
    {
        private int id;
        private string name;
        private List<Ambiente> ambientes = new List<Ambiente>();

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        internal List<Ambiente> Ambientes { get => ambientes; set => ambientes = value; }

        public Usuario() 
        {
        }

        public bool concederPermissao(Ambiente ambiente)
        {
            if (Ambientes.Contains(ambiente))
            {
                return false;
            }

            Ambientes.Add(ambiente);
            return true;
        }

        public bool revogarPermissao(Ambiente ambiente)
        {
            return Ambientes.Remove(ambiente);
        }

        public void listarAcesso()
        {
            if(Ambientes.Count == 0)
            {
                Console.WriteLine("Esse usuario nao possui permissoes");
            } else
            {
                Console.WriteLine("Permissoes de ambientes: \n");
                foreach (Ambiente amb in Ambientes)
                {
                    Console.WriteLine($"Nome: {amb.Name} --- Id: {amb.Id}");
                }
            }
        }
    }
}
