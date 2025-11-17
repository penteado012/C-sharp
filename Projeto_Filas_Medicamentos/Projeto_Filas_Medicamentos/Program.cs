using System;
using System.Collections.Generic;

namespace Projeto_Filas_Medicamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medicamentos medicamentos = new Medicamentos();

            int opcao = -1;
            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine("           MENU DE OPERAÇÕES            ");
                Console.WriteLine("========================================");
                Console.WriteLine("0. Finalizar processo");
                Console.WriteLine("1. Cadastrar medicamento");
                Console.WriteLine("2. Consultar medicamento (sintético)");
                Console.WriteLine("3. Consultar medicamento (analítico)");
                Console.WriteLine("4. Comprar medicamento (cadastrar lote)");
                Console.WriteLine("5. Vender medicamento (abater do lote mais antigo)");
                Console.WriteLine("6. Listar medicamentos (dados sintéticos)");
                Console.WriteLine("========================================");
                Console.Write("Digite a opção desejada: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida! Digite apenas números.");
                    continue;
                }

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Sessão Finalizada!");
                        break;

                    case 1: // Cadastrar medicamento
                        Console.WriteLine("Digite o id para cadastro: ");

                        int idCadastro;
                        if (!int.TryParse(Console.ReadLine(), out idCadastro))
                        {
                            Console.WriteLine("ID inválido!");
                            break;
                        }

                        Console.WriteLine("Digite o nome do seu medicamento: ");
                        string nomeMedicamento = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nomeMedicamento))
                        {
                            Console.WriteLine("Nome não pode ser vazio!");
                            break;
                        }

                        Console.WriteLine("Digite o nome do seu laboratório: ");
                        string nomeLaboratorio = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nomeLaboratorio))
                        {
                            Console.WriteLine("Laboratório não pode ser vazio!");
                            break;
                        }

                        Medicamento medicamento = new Medicamento(idCadastro, nomeMedicamento, nomeLaboratorio);
                        medicamentos.adicionar(medicamento);
                        Console.WriteLine("Medicamento cadastrado com sucesso!");
                        break;

                    case 2: // Consultar medicamento (sintético)
                        Console.WriteLine("Digite o id do medicamento que deseja consultar:");

                        int consulta1;
                        if (!int.TryParse(Console.ReadLine(), out consulta1))
                        {
                            Console.WriteLine("ID inválido!");
                            break;
                        }

                        Medicamento med1 = new Medicamento { Id = consulta1 };
                        Medicamento resultado1 = medicamentos.pesquisar(med1);

                        if (resultado1 == null || resultado1.Id == 0)
                        {
                            Console.WriteLine("Nenhum medicamento com esse ID.");
                        }
                        else
                        {
                            Console.WriteLine(resultado1.ToString());
                        }
                        break;

                    case 3: // Consultar (analítico)
                        Console.WriteLine("Digite o id do medicamento que deseja consultar:");

                        int consulta2;
                        if (!int.TryParse(Console.ReadLine(), out consulta2))
                        {
                            Console.WriteLine("ID inválido!");
                            break;
                        }

                        Medicamento med2 = new Medicamento { Id = consulta2 };
                        Medicamento resultado2 = medicamentos.pesquisar(med2);

                        if (resultado2 == null || resultado2.Id == 0)
                        {
                            Console.WriteLine("Nenhum medicamento com esse ID.");
                        }
                        else
                        {
                            Console.WriteLine(resultado2.ToString());
                            Console.WriteLine("Lotes:");

                            if (resultado2.Lotes.Count == 0)
                            {
                                Console.WriteLine("Nenhum lote cadastrado.");
                            }
                            else
                            {
                                foreach (Lote lote in resultado2.Lotes)
                                {
                                    Console.WriteLine(lote.ToString());
                                }
                            }
                        }
                        break;

                    case 4: // Comprar medicamento (lote)
                        Console.WriteLine("Digite o id do medicamento:");
                        int consulta3;
                        if (!int.TryParse(Console.ReadLine(), out consulta3))
                        {
                            Console.WriteLine("ID inválido!");
                            break;
                        }

                        Medicamento med3 = new Medicamento { Id = consulta3 };
                        Medicamento resultado3 = medicamentos.pesquisar(med3);

                        if (resultado3.Id == 0)
                        {
                            Console.WriteLine("Medicamento não encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Digite o id do lote:");
                            int idLote;
                            if (!int.TryParse(Console.ReadLine(), out idLote))
                            {
                                Console.WriteLine("ID inválido!");
                                break;
                            }

                            Console.WriteLine("Digite a quantidade:");
                            int qtde;
                            if (!int.TryParse(Console.ReadLine(), out qtde) || qtde < 1)
                            {
                                Console.WriteLine("Quantidade inválida!");
                                break;
                            }

                            Console.WriteLine("Digite o dia:");
                            int dia;
                            int mes;
                            int ano;

                            if (!int.TryParse(Console.ReadLine(), out dia))
                            {
                                Console.WriteLine("Dia inválido!");
                                break;
                            }

                            Console.WriteLine("Digite o mês:");
                            if (!int.TryParse(Console.ReadLine(), out mes))
                            {
                                Console.WriteLine("Mês inválido!");
                                break;
                            }

                            Console.WriteLine("Digite o ano:");
                            if (!int.TryParse(Console.ReadLine(), out ano))
                            {
                                Console.WriteLine("Ano inválido!");
                                break;
                            }

                            DateTime vencimento;
                            if (!DateTime.TryParse($"{ano}-{mes}-{dia}", out vencimento))
                            {
                                Console.WriteLine("Data inválida!");
                                break;
                            }

                            resultado3.comprar(new Lote(idLote, qtde, vencimento));
                            Console.WriteLine("Lote cadastrado com sucesso!");
                        }
                        break;

                    case 5: // Vender
                        Console.WriteLine("Digite o id do medicamento:");
                        int consulta4;
                        if (!int.TryParse(Console.ReadLine(), out consulta4))
                        {
                            Console.WriteLine("ID inválido!");
                            break;
                        }

                        Medicamento med4 = new Medicamento { Id = consulta4 };
                        Medicamento resultado4 = medicamentos.pesquisar(med4);

                        if (resultado4.Id == 0)
                        {
                            Console.WriteLine("Medicamento não encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Digite a quantidade para vender:");
                            int qtdVenda;
                            if (!int.TryParse(Console.ReadLine(), out qtdVenda) || qtdVenda < 1)
                            {
                                Console.WriteLine("Quantidade inválida!");
                                break;
                            }

                            if (resultado4.vender(qtdVenda))
                                Console.WriteLine("Venda realizada com sucesso!");
                            else
                                Console.WriteLine("Quantidade indisponível!");
                        }
                        break;

                    case 6: // Listar medicamentos
                        if (medicamentos.ListaMedicamentos.Count == 0)
                        {
                            Console.WriteLine("Nenhum medicamento cadastrado.");
                        }
                        else
                        {
                            foreach (Medicamento m in medicamentos.ListaMedicamentos)
                                Console.WriteLine(m.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != 0);
        }
    }
}
