using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Cursos
{
    internal class Curso
    {
        private int id;
        private string descricao;
        private Disciplina[] disciplinas = new Disciplina[12];
        private static int proximoId = 1;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        internal Disciplina[] Disciplinas { get => disciplinas; set => disciplinas = value; }

        public bool adicionarDisciplina(Disciplina disciplina)
        {
            for(int i = 0; i < this.Disciplinas.Length; i++)
            {
                if(this.Disciplinas[i] == null)
                {
                    this.Disciplinas[i] = disciplina;
                    this.Disciplinas[i].Curso = this;
                    return true;
                }
            }
            return false;
        }

        public Disciplina pesquisarDisciplina(Disciplina disciplina)
        {
            for(int i = 0; i < this.Disciplinas.Length; i++)
            {
                if (this.Disciplinas[i] != null && this.Disciplinas[i].Id == disciplina.Id)
                {
                    return this.Disciplinas[i];
                }
            }
            return null;
        }

        public bool removerDisciplina(Disciplina disciplina)
        {
            for(int i = 0; i < this.Disciplinas.Length; i++)
            {
                if (this.Disciplinas[i] != null && this.Disciplinas[i].Id == disciplina.Id)
                {
                    bool temAlunos = false;

                    foreach (Aluno a in this.Disciplinas[i].Alunos)
                    {
                        if(a != null)
                        {
                            temAlunos = true;
                            break;
                        }
                    }

                    if (temAlunos)
                    {
                        return false;
                    }

                    for(int j = i; j <  this.Disciplinas.Length - 1; j++)
                    {
                        this.Disciplinas[j] = this.Disciplinas[j + 1];
                    }
                    this.Disciplinas[this.Disciplinas.Length - 1] = null;
                    return true;
                }
            }
            return false;   
        }
    }
}
