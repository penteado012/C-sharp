using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Cursos
{
    internal class Disciplina
    {
        private int id;
        private string descricao;
        private Aluno []alunos = new Aluno[15];
        private Curso curso;
        private static int proxID = 1;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        internal Aluno[] Alunos { get => alunos; set => alunos = value; }
        internal Curso Curso { get => curso; set => curso = value; }

        public Disciplina()
        {
            this.id = proxID++;
        }

        public bool matricularAluno(Aluno aluno)
        {
            foreach(Aluno a in this.Alunos)
            {
                if(a != null && a.Id == aluno.Id)
                {
                    return false;
                }
            }

            if (!aluno.podeMatricular(this.Curso))
            {
                return false;
            }

            aluno.Curso = this.Curso;

            for(int i = 0; i < this.Alunos.Length; i++)
            {
                if (this.Alunos[i] == null )
                {
                    this.Alunos[i] = aluno;
                    return true;
                }
            }
            return false;
        }
        public bool desmatricularAluno(Aluno aluno)
        {
            for(int i = 0; i < this.Alunos.Length; i++)
            {
                if(this.Alunos[i] != null && this.Alunos[i].Id == aluno.Id)
                {
                    for (int j = i; j < this.Alunos.Length - 1; j++)
                    {
                        this.Alunos[j] = this.Alunos[j + 1];
                    }
                    this.Alunos[this.Alunos.Length - 1] = null;                    
                    return true;                    
                }
            }
            return false;
        }
    }
}
