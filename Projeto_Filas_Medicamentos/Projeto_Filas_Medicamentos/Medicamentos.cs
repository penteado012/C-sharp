using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Medicamentos
{
    internal class Medicamentos
    {
        private List<Medicamento> listaMedicamentos = new List<Medicamento>();

        internal List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        public Medicamentos()
        {
        
        }

        public void adicionar(Medicamento medicamento)
        {
            if(medicamento != null)
            {
                ListaMedicamentos.Add(medicamento);
            }
        }

        public bool deletar(Medicamento medicamento)
        {
            if(medicamento == null)
                return false;

            if (medicamento.qtdeDisponivel() == 0)
            {
                ListaMedicamentos.Remove(medicamento);
                return true;
            }

            return false;
        }

        public Medicamento pesquisar(Medicamento medicamento)
        {
            foreach (Medicamento m in ListaMedicamentos)
            {
                if(m != null && m.Id == medicamento.Id)
                {
                    return m;
                }
            }

            return new Medicamento();
        }
    }
}
