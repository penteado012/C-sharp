using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Acessos
{
    internal class Ambiente
    {
        private int id;
        private string name;
        private Queue<Log> logs = new Queue<Log>();

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        internal Queue<Log> Logs { get => logs; set => logs = value; }

        public Ambiente() 
        {
            id++;
        }

        public void registrarLog(Log log)
        {
            if (Logs.Count >= 100)
            {
                Logs.Dequeue();
            }

            Logs.Enqueue(log);
        }
    }
}
