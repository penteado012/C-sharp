using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Gerenciamento_de_Projetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Projetos projetos = new Projetos();
            int opcao = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("       GERENCIAMENTO DE PROJETOS E TAREFAS     ");
                Console.WriteLine("==============================================");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Adicionar projeto");
                Console.WriteLine("2. Pesquisar projeto (mostrar tarefas por status e totais)");
                Console.WriteLine("3. Remover projeto (apenas se sem tarefas)");
                Console.WriteLine("4. Adicionar tarefa em projeto");
                Console.WriteLine("5. Concluir tarefa");
                Console.WriteLine("6. Cancelar tarefa");
                Console.WriteLine("7. Reabrir tarefa");
                Console.WriteLine("8. Listar tarefas de um projeto");
                Console.WriteLine("9. Filtrar tarefas por status ou prioridade em um projeto");
                Console.WriteLine("10. Filtrar tarefas por status ou prioridade em todos os projetos");
                Console.WriteLine("11. Resumo geral: quantidade de projetos, tarefas abertas/fechadas/canceladas e % concluídas");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");

                // leitura segura
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                    Console.WriteLine("Opção inválida! Pressione ENTER para continuar...");
                    Console.ReadLine();
                    continue;
                }

                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa... Até logo!");
                        break;

                    case 1:
                        Console.WriteLine("=== Digite o nome do projeto: ===");
                        string nProjeto = Console.ReadLine();
                        Projeto projeto = new Projeto(nProjeto);
                        Console.WriteLine((projetos.adicionar(projeto)) ? "Projeto criado com sucesso!": "Não foi possível criar o projeto!");
                        break;
                    case 2:
                        Console.WriteLine("=== Digite o id do projeto que deseja pesquisar: ===");
                        int idPesquisa = int.Parse(Console.ReadLine());
                        Projeto projeto1 = projetos.buscar(new Projeto(idPesquisa));
                        if(projeto1 != null)
                        {
                            int num1 = 1;
                            int num2 = 1;
                            int num3 = 1;

                            Console.WriteLine("\nTarefas Abertas: ");
                            foreach (Tarefa t in projeto1.tarefasPorStatus("Aberta"))
                            {
                                Console.WriteLine($"Tarefa {num1++}");
                                Console.WriteLine($"Id: {t.Id}");
                                Console.WriteLine($"Descrição: {t.Descricao}");                               
                            }

                            Console.WriteLine("\nTarefas Fechadas: ");
                            foreach (Tarefa t in projeto1.tarefasPorStatus("Fechada"))
                            {
                                Console.WriteLine($"Tarefa {num2++}");
                                Console.WriteLine($"Id: {t.Id}");
                                Console.WriteLine($"Descrição: {t.Descricao}");
                            }

                            Console.WriteLine("\nTarefas Canceladas: ");
                            foreach (Tarefa t in projeto1.tarefasPorStatus("Cancelada"))
                            {
                                Console.WriteLine($"Tarefa {num3++}");
                                Console.WriteLine($"Id: {t.Id}");
                                Console.WriteLine($"Descrição: {t.Descricao}");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("=== Digite o id do seu projeto: ===");
                        int idProjeto = int.Parse(Console.ReadLine());
                        Projeto projeto2 = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjeto);
                        if (projeto2 == null)
                        {
                            Console.WriteLine("ERRO!!! Não foi possível achar um projeto com esse ID!");
                        }
                        else if (projeto2.Tarefas.Count > 0)
                        {
                            Console.WriteLine("ERRO!!! Não é possível remover um projeto que ainda possui tarefas!");
                        }
                        else
                        {
                            projetos.Itens.Remove(projeto2);
                            Console.WriteLine("Projeto removido com sucesso!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("===  Digite o id do projeto que deseja adicionar uma tarefa:  ===");
                        int idProjeto1 = int.Parse(Console.ReadLine());
                        Projeto projeto3 = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjeto1);
                        if (projeto3 == null)
                        {
                            Console.WriteLine("ERRO!!! Não foi possível achar um projeto com esse ID!");
                        }
                        else
                        {
                            Console.WriteLine("Digite o titulo da sua tarefa: ");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Digite a descrição da sua tarefa: ");
                            string descricao = Console.ReadLine();
                            Console.WriteLine("Digite a prioridade da sua tarefa: ");
                            int prioridade = int.Parse(Console.ReadLine());
                            Tarefa tarefa = new Tarefa(titulo, descricao, prioridade);
                            projeto3.AdicionarTarefa(tarefa);
                        }
                        break;
                    case 5:
                        Console.WriteLine("=== Concluir Tarefa ===");
                        // chamar método para concluir
                        break;

                    case 6:
                        Console.WriteLine("=== Cancelar Tarefa ===");
                        // chamar método para cancelar
                        break;

                    case 7:
                        Console.WriteLine("=== Reabrir Tarefa ===");
                        // chamar método para reabrir
                        break;

                    case 8:
                        Console.WriteLine("=== Listar Tarefas de um Projeto ===");
                        // listar tarefas do projeto selecionado
                        break;

                    case 9:
                        Console.WriteLine("=== Filtrar Tarefas (Status ou Prioridade) - Projeto ===");
                        // filtro por status ou prioridade em 1 projeto
                        break;

                    case 10:
                        Console.WriteLine("=== Filtrar Tarefas (Status ou Prioridade) - Todos os Projetos ===");
                        // filtro geral
                        break;

                    case 11:
                        Console.WriteLine("=== Resumo Geral ===");
                        // total de projetos e estatísticas
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                    Console.ReadLine();
                }
            } while (opcao != 0);   
        }    
    }
}

