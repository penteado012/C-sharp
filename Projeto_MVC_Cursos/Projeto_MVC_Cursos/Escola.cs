using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Cursos
{
    internal class Escola
    {
        private Curso []cursos = new Curso[5];
        internal Curso[] Cursos { get => cursos; set => cursos = value; }
        private static int proxId = 1;

        public bool adicionarCurso(Curso curso)
        {
            for(int i = 0; i < this.Cursos.Length; i++)
            {
                if (this.Cursos[i] == null)
                {
                    this.Cursos[i] = curso;
                    this.Cursos[i].Id = proxId++; 
                    return true;
                }
            }
            return false;
        }
        public Curso pesquisarCurso (Curso curso)
        {
            foreach (var p in this.Cursos)
            {
                if(p != null && p.Id == curso.Id)
                {
                    return p;
                }
            }
            return null;
        }

        public bool removerCurso(Curso curso)
        {
            for(int i = 0; i <this.Cursos.Length; i++)
            {
                if (this.Cursos[i] != null && this.Cursos[i].Id == curso.Id)
                {
                    bool temDisciplina = false;
                    foreach (Disciplina d in this.Cursos[i].Disciplinas)
                    {
                        if (d != null)
                        {
                            temDisciplina = true;
                            break;
                        }
                    }

                    if (temDisciplina)
                    {
                        return false;
                    }

                    for(int j = i; j < this.Cursos.Length - 1; j++)
                    {
                        this.Cursos[j] = this.Cursos[j + 1];
                    }
                    this.Cursos[Cursos.Length - 1] = null;
                    return true;
                }
            }
            return false;
        }
    }
}
