using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Cursos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            int opcao;
            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("       MENU DE OPÇÕES");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Adicionar curso");
                Console.WriteLine("2. Pesquisar curso");
                Console.WriteLine("3. Remover curso");
                Console.WriteLine("4. Adicionar disciplina no curso");
                Console.WriteLine("5. Pesquisar disciplina");
                Console.WriteLine("6. Remover disciplina do curso");
                Console.WriteLine("7. Matricular aluno na disciplina");
                Console.WriteLine("8. Remover aluno da disciplina");
                Console.WriteLine("9. Pesquisar aluno");
                Console.WriteLine("0. Sair");
                Console.WriteLine("------------------------------");
                Console.Write("Digite a opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro:");
                }
                int idCurso;
                int idDisciplina;
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o  nome do seu curso: ");
                        string nomeCurso = Console.ReadLine();
                        Curso curso = new Curso { Descricao = nomeCurso };
                        if (escola.adicionarCurso(curso))
                        {
                            Console.WriteLine("Curso adicionado com sucesso!");
                            Console.WriteLine($"Id do curso: {curso.Id}");
                            Console.WriteLine($"Nome do curso: {curso.Descricao}");
                            break;
                        }
                            Console.WriteLine("Não foi possível adicionar o curso. Limite atingido.");
                            break;
                    case 2:
                        Console.WriteLine("Digite o ID do curso que deseja pesquisar: ");
                        while (!int.TryParse(Console.ReadLine(), out idCurso))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }
                        Curso curso1 = new Curso {Id = idCurso };
                        Curso cursoEncontrado = escola.pesquisarCurso(curso1);
                        if(cursoEncontrado != null)
                        {
                            Console.WriteLine("Curso encontrado!");
                            Console.WriteLine("Id: " + cursoEncontrado.Id);
                            Console.WriteLine("Nome: " + cursoEncontrado.Descricao);

                            Console.WriteLine("\nDisciplinas desse curso: ");
                            bool temDisciplina = false;
                            foreach (var discipina in cursoEncontrado.Disciplinas)
                            {
                                if(discipina != null)
                                {
                                    Console.WriteLine("Id: " + discipina.Id + "\nNome: " + discipina.Descricao);
                                    temDisciplina = true;
                                }
                            }

                            if (!temDisciplina)
                            {
                                Console.WriteLine("Não tem Disciplina");
                            }
                            break;
                        }
                            Console.WriteLine("Curso não encontrado");
                            break;
                    case 3:
                        Console.WriteLine("Digite o id do curso que deseja remover: ");
                        while (!int.TryParse(Console.ReadLine(), out idCurso))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Curso removeCurso = escola.Cursos.FirstOrDefault(c => c != null && c.Id == idCurso);

                        if(removeCurso == null)
                        {
                            Console.WriteLine("Curso não foi enctrado!");
                        } else if (escola.removerCurso(removeCurso))
                        {
                            Console.WriteLine("Curso Removido com Sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível remover o curso porque possui disciplinas associadas.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o ID do curso que deseja adicionar a disciplina: ");
                        while (!int.TryParse(Console.ReadLine(), out idCurso))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }
                        Curso curso2 = escola.Cursos.FirstOrDefault(c => c != null && c.Id == idCurso);

                        if(curso2 == null)
                        {
                            Console.WriteLine("Curso não existe!");
                            break;
                        }

                        Console.WriteLine("Digite o nome da disciplina: ");
                        string nomeDisciplina = Console.ReadLine();

                        Disciplina disciplina = new Disciplina {Descricao = nomeDisciplina };

                        if (curso2.adicionarDisciplina(disciplina))
                        {
                            Console.WriteLine("Disciplina adicionada com sucesso!");
                        } else
                        {
                            Console.WriteLine("Número maximo de disciplinas ja cadastradas!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Digite o id da disciplina que deseja pesquisar: ");
                        while (!int.TryParse(Console.ReadLine(), out idDisciplina))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Disciplina buscaDisciplina = new Disciplina {Id = idDisciplina };
                        Disciplina disciplinaEncontrada = null;

                        foreach (var cursoAtual in escola.Cursos)
                        {
                            if(cursoAtual != null)
                            {
                                disciplinaEncontrada = cursoAtual.pesquisarDisciplina(buscaDisciplina);
                                if(disciplinaEncontrada != null)
                                {
                                    Console.WriteLine("Disciplina encontrada! ");
                                    break;
                                }
                            }
                        }
                        if(disciplinaEncontrada != null)
                        {
                            Console.WriteLine("Id da Disciplina: " + disciplinaEncontrada.Id);
                            Console.WriteLine("Nome da Disciplina: " + disciplinaEncontrada.Descricao);

                            Console.WriteLine("Alunos matriculados nessa disciplina: ");
                            bool temaluno = false;
                            foreach (var a in disciplinaEncontrada.Alunos)
                            {
                                if(a != null)
                                {
                                    Console.WriteLine("Id do Aluno: " + a.Id + "Nome do Aluno: " + a.Nome);
                                    temaluno = true;
                                }
                            }
                            if (!temaluno)
                            {
                                Console.WriteLine("Não tem alunos matriculados nessa disciplina");
                            }
                        } else
                        {
                            Console.WriteLine("Disciplina não encontrada nesse curso");
                        }
                            break;
                    case 6:
                        Console.WriteLine("Digite o id da disciplina que deseja remover: ");
                        while (!int.TryParse(Console.ReadLine(), out idDisciplina))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Disciplina buscaDisciplina1 = new Disciplina { Id = idDisciplina};
                        Disciplina disciplinaEncontrada1 = null;
                        Curso cursoDaDisciplina = null;

                        foreach (var c in escola.Cursos)
                        {
                            if(c != null)
                            {
                                disciplinaEncontrada1 = c.pesquisarDisciplina(buscaDisciplina1);
                                if (disciplinaEncontrada1 != null)
                                {
                                    //Disciplina econtrada;
                                    cursoDaDisciplina = disciplinaEncontrada1.Curso;
                                    break;
                                }
                            }
                        }

                        if (disciplinaEncontrada1 != null)
                        {
                            if (cursoDaDisciplina.removerDisciplina(disciplinaEncontrada1))
                            {
                                Console.WriteLine("Disciplina removida com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Disciplina não pode ser removida, pois contém alunos matriculados nessa disciplina");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Disciplina não encontrada! ");
                        }
                            break;
                    case 7:
                        Curso salvarCurso = null;
                        Disciplina salvarDisciplina = null;

                        Console.WriteLine("Digite o nome do aluno: ");
                        string nomeAluno = Console.ReadLine();
                        Aluno aluno1 = new Aluno {Nome = nomeAluno };

                        Console.WriteLine("Digite o id do curso da disciplina que deseja matricular o aluno: ");
                        int idCurso1;
                        while (!int.TryParse(Console.ReadLine(), out idCurso1))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        foreach (var c in escola.Cursos)
                        {
                            if(c != null && c.Id == idCurso1)
                            {
                                salvarCurso = c;
                                break;
                            }
                        }

                        if(salvarCurso == null)
                        {
                            Console.WriteLine("Curso não existe! ");
                            break;
                        }

                        Console.WriteLine("Digite o id da disciplina que deseja matricular o aluno: ");
                        int idDisciplina1;
                        while (!int.TryParse(Console.ReadLine(), out idDisciplina1))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        foreach (var d in salvarCurso.Disciplinas)
                        {
                            if(d != null && d.Id == idDisciplina1)
                            {
                                salvarDisciplina = d; 
                                break;
                            }
                        }

                        if(salvarDisciplina == null)
                        {
                            Console.WriteLine("Disciplina não existe");
                            break;
                        }

                        if (aluno1.podeMatricular(salvarCurso))
                        {
                            if (salvarDisciplina.matricularAluno(aluno1))
                            {
                                Console.WriteLine("Aluno Matriculado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Aluno ja esta matriculado em outro curso!");
                            }                            
                        }
                        else
                        {
                            Console.WriteLine("Maximo de alunos inscritos para essa disciplina");
                        }
                        break;
                    case 8:
                        Console.WriteLine("Digite o id do curso em que o aluno esta matriculado: ");
                        int idCurso2;
                        while (!int.TryParse(Console.ReadLine(), out idCurso2))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Curso curso3 = escola.Cursos.FirstOrDefault(c => c != null && c.Id == idCurso2);

                        if(curso3 == null)
                        {
                            Console.WriteLine("Id de curso inválido!");
                            break;
                        }

                        Console.WriteLine("Digite o id da Disciplina para remover o aluno: ");
                        int idDisciplina2;
                        while (!int.TryParse(Console.ReadLine(), out idDisciplina2))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Disciplina disciplina1 = curso3.Disciplinas.FirstOrDefault(c => c != null && c.Id == idDisciplina2);
                        if(disciplina1 == null)
                        {
                            Console.WriteLine("Id da disciplina inválido!");
                            break;
                        }

                        Console.WriteLine("Digite o id do aluno que deseja remover: ");
                        int idAluno1;
                        while (!int.TryParse(Console.ReadLine(), out idAluno1))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Aluno aluno2 = disciplina1.Alunos.FirstOrDefault(c => c != null && c.Id == idAluno1);

                        if(aluno2 == null)
                        {
                            Console.WriteLine("Id de aluno inválido!");
                            break;
                        }

                        if (disciplina1.desmatricularAluno(aluno2))
                        {
                            Console.WriteLine("Aluno desmatriculado!");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível remover o aluno da disciplina");
                        }

                        break;
                    case 9:
                        Console.WriteLine("Digite o id do Aluno: ");
                        int idAluno;
                        while (!int.TryParse(Console.ReadLine(), out idAluno))
                        {
                            Console.WriteLine("ID inválido! Digite um número inteiro:");
                        }

                        Aluno alunoEncontrado = null;
                        bool temDisciplina1 = false;

                        foreach (var c in escola.Cursos)
                        {
                            if(c != null)
                            {
                                foreach (var d in c.Disciplinas)
                                {
                                    if(d != null)
                                    {
                                        foreach (var a in d.Alunos)
                                        {
                                            if(a != null && a.Id == idAluno)
                                            {
                                                if (alunoEncontrado == null)
                                                {
                                                    alunoEncontrado = a;
                                                    Console.WriteLine("Aluno encontrado!");
                                                    Console.WriteLine($"Nome: {alunoEncontrado.Nome} ");
                                                    Console.WriteLine("Disciplinas matriculadas:");
                                                }
                                                Console.WriteLine($"Curso: {c.Descricao} - Disciplina: {d.Descricao}");
                                                temDisciplina1 = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (!temDisciplina1)
                        {
                            Console.WriteLine("Aluno não encontrado em nenhuma disciplina.");
                        }

                        break;
                    default:
                        if (opcao != 0)
                        {
                            Console.WriteLine("Opção inválida! Tente novamente.");
                        }
                        break;
                }
            } while (opcao != 0);
        }
    }
}
