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
                        Console.WriteLine((projetos.adicionar(projeto)) ? "Projeto criado com sucesso!" : "Não foi possível criar o projeto!");
                        break;
                    case 2:
                        Console.WriteLine("=== Digite o id do projeto que deseja pesquisar: ===");
                        int idPesquisa = int.Parse(Console.ReadLine());
                        Projeto projeto1 = projetos.buscar(new Projeto(idPesquisa));
                        if (projeto1 != null)
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
                            Tarefa tarefa1 = new Tarefa(titulo, descricao, prioridade);
                            projeto3.AdicionarTarefa(tarefa1);
                        }
                        break;
                    case 5:
                        Console.WriteLine("=== Digite o id do projeto: ===");
                        int idProjeto2 = int.Parse(Console.ReadLine());
                        Projeto projeto4 = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjeto2);

                        if (projeto4 == null)
                        {
                            Console.WriteLine("ERRO!!! Id do projeto não existe!");
                        }
                        else
                        {
                            Console.WriteLine("Digite id da tarefa que deseja concluir: ");
                            int idTarefa = int.Parse(Console.ReadLine());
                            Tarefa tarefa = projeto4.Tarefas.FirstOrDefault(t => t != null && t.Id == idTarefa);

                            if (tarefa == null)
                            {
                                Console.WriteLine("ERRO!!! Id da tarefa não encontrado!");
                            }
                            else
                            {
                                if (tarefa.Status == "Fechada")
                                {
                                    Console.WriteLine("ERRO!!! Não foi possível concluir sua tarefa, pois ela está Fechada!");
                                }
                                else if (tarefa.Status == "Cancelada")
                                {
                                    Console.WriteLine("ERRO!!! Não foi possível concluir sua tarefa, pois ela está Cancelada!");
                                }
                                else
                                {
                                    tarefa.concluir();
                                    Console.WriteLine("Sua tarefa foi concluída com sucesso!");
                                }
                            }
                        }
                        break;
                    case 6:
                        Console.WriteLine("=== Digite o id do projeto: ===");
                        int idProjeto3 = int.Parse(Console.ReadLine());
                        Projeto projeto5 = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjeto3);
                        if (projeto5 == null)
                        {
                            Console.WriteLine("ERRO!!! Não foi possível encontrar id desse projeto!");
                        }
                        else
                        {
                            Console.WriteLine("Digite o id da tarefa: ");
                            int idTarefa2 = int.Parse(Console.ReadLine());
                            Tarefa tarefa2 = projeto5.Tarefas.FirstOrDefault(p => p != null && p.Id == idTarefa2);
                            if (tarefa2 == null)
                            {
                                Console.WriteLine("ERRO!!! Não existe tarefa com esse id!");
                            }
                            else
                            {
                                if (tarefa2.Status == "Cancelada")
                                {
                                    Console.WriteLine("Sua tarefa ja estava cancelada!");
                                }
                                else if (tarefa2.Status == "Fechada")
                                {
                                    Console.WriteLine("ERRO!!! Não foi possível Cancelar sua tarefa, pois ela está fechada!");
                                }
                                else
                                {
                                    tarefa2.cancelar();
                                    Console.WriteLine("Sua tarefa foi cancelada com sucesso!");
                                }
                            }
                        }
                        break;
                    case 7:
                        Console.WriteLine("=== Digite o id do projeto: ===");
                        int idProjeto4 = int.Parse(Console.ReadLine());
                        Projeto projeto6 = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjeto4);
                        if (projeto6 == null)
                        {
                            Console.WriteLine("ERRO!!! Não foi possível encontrar um projeto com esse id!");
                        }
                        else
                        {
                            Console.WriteLine("Digite o id da sua tarefa: ");
                            int idTarefa3 = int.Parse(Console.ReadLine());
                            Tarefa tarefa3 = projeto6.Tarefas.FirstOrDefault(t => t != null && t.Id == idTarefa3);
                            if (tarefa3 == null)
                            {
                                Console.WriteLine("Não foi possível achar uma tarefa com esse id!");
                            }
                            else if (tarefa3.Status == "Aberta")
                            {
                                Console.WriteLine("Sua tarefa já esta aberta!");
                            }
                            else if (tarefa3.Status == "Cancelada")
                            {
                                Console.WriteLine("ERRO!!! Sua tarefa não pode ser reaberta, pois está cancelada!");
                            }
                            else
                            {
                                tarefa3.reabrir();
                                Console.WriteLine("Sua tarefa foi reaberta com sucesso!!!");
                            }
                        }
                        break;
                    case 8:
                        Console.WriteLine("=== Digite o id do seu projeto: ===");
                        int idProjeto5 = int.Parse(Console.ReadLine());
                        Projeto projeto7 = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjeto5);
                        if (projeto7 == null)
                        {
                            Console.WriteLine("ERRO!!! Não foi possível encontrar o id desse projeto!");
                        }
                        else
                        {
                            if (projeto7.Tarefas.Count == 0)
                            {
                                Console.WriteLine("Não tem tarefas nesse projeto!");
                            }
                            else
                            {
                                foreach (Tarefa t in projeto7.Tarefas)
                                {
                                    Console.WriteLine($"Id: {t.Id}\nTitulo: {t.Titulo}\n Descrição: {t.Descricao}\n Data criação: {t.DataCriacao}\n Data Conslusão: {t.DataConclusao}");
                                }
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine("=== DIGITE O ID DO PROJETO: ===");
                        int idProjetoFiltro = int.Parse(Console.ReadLine());
                        Projeto projetoFiltro = projetos.Itens.FirstOrDefault(p => p != null && p.Id == idProjetoFiltro);

                        if (projetoFiltro == null)
                        {
                            Console.WriteLine("ERRO!!! Não foi possível encontrar um projeto com esse ID!");
                        }
                        else if (projetoFiltro.Tarefas == null || projetoFiltro.Tarefas.Count == 0)
                        {
                            Console.WriteLine("Este projeto não possui tarefas cadastradas!");
                        }
                        else
                        {
                            Console.WriteLine("Deseja filtrar por:");
                            Console.WriteLine("1 - Status");
                            Console.WriteLine("2 - Prioridade");
                            int opcaoFiltro = int.Parse(Console.ReadLine());

                            List<Tarefa> tarefasFiltradas = new List<Tarefa>();

                            if (opcaoFiltro == 1)
                            {
                                Console.WriteLine("Digite o status (Aberta / Fechada / Cancelada): ");
                                string status = Console.ReadLine();

                                tarefasFiltradas = projetoFiltro.Tarefas
                                    .Where(t => t != null && t.Status.Equals(status, StringComparison.OrdinalIgnoreCase))
                                    .ToList();
                            }
                            else if (opcaoFiltro == 2)
                            {
                                Console.WriteLine("Digite a prioridade (número): ");
                                int prioridadeFiltro = int.Parse(Console.ReadLine());

                                tarefasFiltradas = projetoFiltro.Tarefas
                                    .Where(t => t != null && t.Prioridade == prioridadeFiltro)
                                    .ToList();
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida!");
                                break;
                            }

                            if (tarefasFiltradas.Count == 0)
                            {
                                Console.WriteLine("Nenhuma tarefa encontrada com esse filtro!");
                            }
                            else
                            {
                                Console.WriteLine("=== RESULTADO DO FILTRO ===");
                                foreach (Tarefa t in tarefasFiltradas)
                                {
                                    Console.WriteLine($"ID: {t.Id}");
                                    Console.WriteLine($"Título: {t.Titulo}");
                                    Console.WriteLine($"Descrição: {t.Descricao}");
                                    Console.WriteLine($"Prioridade: {t.Prioridade}");
                                    Console.WriteLine($"Status: {t.Status}");
                                    Console.WriteLine("----------------------------");
                                }
                            }
                        }
                        break;
                    case 10:
                        Console.WriteLine("=== Filtrar Tarefas (Status ou Prioridade) - Todos os Projetos ===");

                        // verifica se há projetos
                        if (projetos.Itens == null || projetos.Itens.Count == 0)
                        {
                            Console.WriteLine("Não há projetos cadastrados.");
                            break;
                        }

                        // verifica se existe ao menos uma tarefa em todos os projetos
                        bool temTarefa = projetos.Itens.Any(pr => pr != null && pr.Tarefas != null && pr.Tarefas.Count > 0);
                        if (!temTarefa)
                        {
                            Console.WriteLine("Não há tarefas cadastradas em nenhum projeto.");
                            break;
                        }

                        Console.WriteLine("Filtrar por Status [s]  Filtrar por Prioridade [p]");
                        char opc = char.ToLower(Console.ReadKey().KeyChar);
                        Console.WriteLine();

                        int totalEncontrados = 0;

                        if (opc == 's')
                        {
                            Console.WriteLine("Digite por qual status deseja filtrar: [1] Aberta | [2] Fechada | [3] Cancelada");
                            if (!int.TryParse(Console.ReadLine(), out int escolhaStatus) || escolhaStatus < 1 || escolhaStatus > 3)
                            {
                                Console.WriteLine("Opção de status inválida.");
                                break;
                            }

                            string statusFiltro = null;
                            if (escolhaStatus == 1) statusFiltro = "Aberta";
                            else if (escolhaStatus == 2) statusFiltro = "Fechada";
                            else if (escolhaStatus == 3) statusFiltro = "Cancelada";

                            Console.WriteLine($"\n--- Tarefas com status: {statusFiltro} (em todos os projetos) ---");
                            foreach (Projeto pr in projetos.Itens)
                            {
                                if (pr == null || pr.Tarefas == null) continue;

                                var lista = pr.Tarefas.Where(t => t != null && !string.IsNullOrEmpty(t.Status)
                                                                  && t.Status.Equals(statusFiltro, StringComparison.OrdinalIgnoreCase))
                                                      .ToList();

                                if (lista.Count > 0)
                                {
                                    Console.WriteLine($"\nProjeto Id: {pr.Id} - Nome: {(string.IsNullOrEmpty(pr.Nome) ? "(sem nome)" : pr.Nome)}");
                                    int idx = 1;
                                    foreach (var t in lista)
                                    {
                                        Console.WriteLine($"  Tarefa {idx++}");
                                        Console.WriteLine($"    Id: {t.Id}");
                                        Console.WriteLine($"    Título: {t.Titulo}");
                                        Console.WriteLine($"    Descrição: {t.Descricao}");
                                        Console.WriteLine($"    Prioridade: {t.Prioridade}");
                                    }
                                    totalEncontrados += lista.Count;
                                }
                            }

                            if (totalEncontrados == 0)
                                Console.WriteLine("Nenhuma tarefa encontrada com esse status.");
                            else
                                Console.WriteLine($"\nTotal encontrado: {totalEncontrados}");
                        }
                        else if (opc == 'p')
                        {
                            Console.WriteLine("Digite a prioridade a filtrar (1 = Alta, 2 = Média, 3 = Baixa):");
                            if (!int.TryParse(Console.ReadLine(), out int prioridadeFiltro) || prioridadeFiltro < 1 || prioridadeFiltro > 3)
                            {
                                Console.WriteLine("Prioridade inválida.");
                                break;
                            }

                            Console.WriteLine($"\n--- Tarefas com prioridade: {prioridadeFiltro} (em todos os projetos) ---");
                            foreach (Projeto pr in projetos.Itens)
                            {
                                if (pr == null || pr.Tarefas == null) continue;

                                var lista = pr.Tarefas.Where(t => t != null && t.Prioridade == prioridadeFiltro).ToList();

                                if (lista.Count > 0)
                                {
                                    Console.WriteLine($"\nProjeto Id: {pr.Id} - Nome: {(string.IsNullOrEmpty(pr.Nome) ? "(sem nome)" : pr.Nome)}");
                                    int idx = 1;
                                    foreach (var t in lista)
                                    {
                                        Console.WriteLine($"  Tarefa {idx++}");
                                        Console.WriteLine($"    Id: {t.Id}");
                                        Console.WriteLine($"    Título: {t.Titulo}");
                                        Console.WriteLine($"    Descrição: {t.Descricao}");
                                        Console.WriteLine($"    Status: {t.Status}");
                                    }
                                    totalEncontrados += lista.Count;
                                }
                            }

                            if (totalEncontrados == 0)
                                Console.WriteLine("Nenhuma tarefa encontrada com essa prioridade.");
                            else
                                Console.WriteLine($"\nTotal encontrado: {totalEncontrados}");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                        break;

                    case 11:
                        Console.WriteLine("=== Resumo Geral ===");

                        int totalProjetos = (projetos.Itens == null) ? 0 : projetos.Itens.Count;
                        int totalAbertas = 0;
                        int totalFechadas = 0;
                        int totalCanceladas = 0;

                        if (projetos.Itens != null)
                        {
                            foreach (Projeto pr in projetos.Itens)
                            {
                                if (pr == null || pr.Tarefas == null) continue;

                                foreach (Tarefa t in pr.Tarefas)
                                {
                                    if (t == null || string.IsNullOrEmpty(t.Status)) continue;

                                    if (t.Status.Equals("Aberta", StringComparison.OrdinalIgnoreCase))
                                        totalAbertas++;
                                    else if (t.Status.Equals("Fechada", StringComparison.OrdinalIgnoreCase))
                                        totalFechadas++;
                                    else if (t.Status.Equals("Cancelada", StringComparison.OrdinalIgnoreCase))
                                        totalCanceladas++;
                                }
                            }
                        }
                        int totalTarefas = totalAbertas + totalFechadas + totalCanceladas;

                        Console.WriteLine($"Quantidade de projetos: {totalProjetos}");
                        Console.WriteLine($"Tarefas Abertas: {totalAbertas}");
                        Console.WriteLine($"Tarefas Fechadas: {totalFechadas}");
                        Console.WriteLine($"Tarefas Canceladas: {totalCanceladas}");
                        Console.WriteLine($"Total de tarefas: {totalTarefas}");

                        if (totalAbertas > 0)
                        {
                            double percFechadasRelAbertas = (double)totalFechadas * 100.0 / totalAbertas;
                            Console.WriteLine($"% de tarefas concluídas em relação às abertas: {percFechadasRelAbertas:F2}%");
                        }
                        else
                        {
                            Console.WriteLine("% de tarefas concluídas em relação às abertas: N/A (não há tarefas abertas)");
                        }
                        if (totalTarefas > 0)
                        {
                            double percFechadasTotal = (double)totalFechadas * 100.0 / totalTarefas;
                            Console.WriteLine($"% de tarefas concluídas em relação ao total: {percFechadasTotal:F2}%");
                        }

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

