using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Medicamentos
{
    internal class Medicamento
    {
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes = new Queue<Lote>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Laboratorio { get => laboratorio; set => laboratorio = value; }
        internal Queue<Lote> Lotes { get => lotes; set => lotes = value; }

        public Medicamento()
        {

        }

        public Medicamento(int id, string nome, string laboratorio)
        {
            this.Id = id;
            this.Nome = nome;   
            this.Laboratorio = laboratorio;
        }        

        public int qtdeDisponivel()
        {
            int disp = 0;
            foreach (Lote lote in lotes)
            {
                if (lote != null)
                {
                    disp += lote.Qtde;
                }
            }
            return disp;
        }

        public void comprar(Lote lote)
        {
            Lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {
            if(qtde > qtdeDisponivel())
            {
                return false;
            }

            while (qtde > 0)
            {
                Lote Plote = Lotes.Peek();

                if (Plote.Qtde <= qtde)
                {
                    qtde -= Plote.Qtde;

                    Lotes.Dequeue();
                } else
                {
                    Plote.Qtde -= qtde;

                    qtde = 0;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return id + "-" + nome + "-" + laboratorio + "-" + qtdeDisponivel(); ;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!(obj is Medicamento))
            {
                return false;
            }

            Medicamento outro = (Medicamento)obj;

            if(this.id == outro.id)
            {
                return true;
            }

            return false;
        }
    }
}
