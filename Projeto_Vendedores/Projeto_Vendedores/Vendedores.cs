using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendedores
{
    internal class Vendedores
    {
        private Vendedor[] osVendedores = new Vendedor[10];
        private int max;
        private int qtde;
        private int proxId = 1;

        public Vendedor[] OsVendedores {get => osVendedores;}    
        public int Max { get => max; set => max = value; }
        public int Qtde { get => qtde; set => qtde = value; }

        public bool addVendedor (Vendedor v)
        {
            for(int i = 0; i < OsVendedores.Length; i++)
            {
                if (OsVendedores[i] == null) 
                {
                    v.Id = proxId;
                    OsVendedores[i] = v;
                    qtde++;
                    proxId++;
                    return true;
                }                 
            }
            return false;
        }

        public bool delVendedor(Vendedor v)
        {
            for (int i = 0; i < OsVendedores.Length; i++)
            {
                if (OsVendedores[i] != null && OsVendedores[i].Id == v.Id)
                {
                    bool temvenda = false;
                    foreach (var venda in OsVendedores[i].AsVendas)
                    {
                        if (venda != null)
                        {
                            temvenda = true;
                            break;
                        }
                    }

                    if (temvenda)
                    {
                        return false;
                    }
                    else
                    {
                        // Remove o vendedor
                        OsVendedores[i] = null;
                        qtde--;

                        // Desloca os elementos à frente e ajusta os IDs
                        for (int j = i; j < OsVendedores.Length - 1; j++)
                        {
                            OsVendedores[j] = OsVendedores[j + 1];

                            if (OsVendedores[j] != null)
                                OsVendedores[j].Id = j + 1; // mantém ID começando em 1
                        }

                        // Última posição fica nula
                        OsVendedores[OsVendedores.Length - 1] = null;

                        return true;
                    }
                }
            }
            return false;
        }




        public Vendedor searchVendedor(Vendedor v) 
        {
            for (int i = 0; i < OsVendedores.Length; i++) 
            {
                if (OsVendedores[i] != null && OsVendedores[i].Id == v.Id) 
                {
                    return OsVendedores[i];
                }
            }
            return null;
        }

        public double valorVendas() 
        {
            double total = 0;
            for (int i = 0; i < OsVendedores.Length; i++) 
            {
                if (OsVendedores[i] != null) 
                {
                    total += OsVendedores[i].valorVendas();
                }
            }
            return total;
        }

        public double valorComissao() 
        {
            double total = 0;
            for (int i = 0; i < OsVendedores.Length; i++) 
            {
                if (OsVendedores[i] != null) 
                {
                    total += OsVendedores[i].valorComissao();
                }
            }
            return total;
        }
    }
}
