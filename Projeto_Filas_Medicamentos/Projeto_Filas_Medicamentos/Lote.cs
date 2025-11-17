using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Medicamentos
{
    internal class Lote
    {
        private int id;
        private int qtde;
        private DateTime venc;

        public int Id { get => id; set => id = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public DateTime Venc { get => venc; set => venc = value; }

        public Lote()
        {

        }

        public Lote(int Id, int Qtde, DateTime Venc)
        {
            this.Id = Id;
            this.Qtde = Qtde;
            this.Venc = Venc;
        }
        
        public string toString()
        {
            return Id + "-" + Qtde + "-" + Venc;
        }
    }
}
