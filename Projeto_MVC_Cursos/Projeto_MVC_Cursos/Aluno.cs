using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Cursos
{
    internal class Aluno
    {
        private int id;
        private string nome;
        private Curso curso;
        private static int proxId = 1;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal Curso Curso { get => curso; set => curso = value; }

        public Aluno()
        {
            this.id = proxId++;
        }

        public bool podeMatricular(Curso cursos)
        {
            if(this.curso != null && this.curso != cursos)
            {
                return false;
            }

            int qtdDisciplinasAluno = 0;
            foreach (Disciplina d in cursos.Disciplinas)
            {
                if (d != null)
                {
                    foreach (Aluno a in d.Alunos)
                    {
                        if (a != null && a.Id == this.Id)
                        {
                            qtdDisciplinasAluno++;
                        }
                    }
                }
            }
            return qtdDisciplinasAluno < 6;
        }
    }
}
