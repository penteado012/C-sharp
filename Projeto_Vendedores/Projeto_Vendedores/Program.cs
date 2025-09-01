using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Vendedores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Vendedores vendedores = new Vendedores();

            do
            {
                Console.WriteLine("0. Sair\r\n1. Cadastrar vendedor\r\n2. Consultar vendedor\r\n3. Excluir vendedor\r\n4. Registrar venda\r\n5. Listar vendedores\n");
                valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        {
                            // Cadastrar vendedor
                            Console.WriteLine("\nDigite seu nome: ");
                            string nome = Console.ReadLine();

                            Console.WriteLine("Digite a porcentagem de comissão: ");
                            double percComissao = double.Parse(Console.ReadLine());

                            Vendedor vendedor = new Vendedor();
                            vendedor.Nome = nome;
                            vendedor.PercComissao = percComissao;

                            if (vendedores.addVendedor(vendedor))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nVendedor Cadastrado com Sucesso!\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(vendedor.dadosVendedor());
                                Console.ResetColor();
                                break;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("!!!Erro: número máximo de vendedores atingido!");
                                Console.ResetColor();
                                break;
                            }
                        }
                    case 2:
                        {
                            //Pesquisar Vendedor
                            Console.WriteLine("\nDigite o ID do vendedor: ");
                            int id = int.Parse(Console.ReadLine());

                            Vendedor vendedorBusca = new Vendedor();
                            vendedorBusca.Id = id;

                            Vendedor vendedorEncontrado = vendedores.searchVendedor(vendedorBusca);

                            if (vendedorEncontrado != null)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nVendedor encontrado!\n");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine(vendedorEncontrado.dadosVendedor());
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n!!!Erro: vendedor não encontrado!\n");
                                Console.ResetColor();
                            }

                            break;
                        }

                    case 3:
                        {
                            // Excluir vendedor
                            Console.WriteLine("\nDigite o ID do vendedor: ");
                            int id = int.Parse(Console.ReadLine());

                            Vendedor vendedor = vendedores.OsVendedores.FirstOrDefault(vend => vend != null && vend.Id == id);

                            if (vendedor != null)
                            {
                                if (vendedores.delVendedor(vendedor))
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nVendedor Deletado com Sucesso!\n");
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nErro: não é possível excluir (há vendas registradas com esse vendendor)!\n");
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n!!!Erro: vendedor não encontrado!\n");
                                Console.ResetColor();
                            }
                            break;
                        }
                    case 4:
                        {
                            // Registrar venda
                            Console.WriteLine("\nDigite o Id do vendedor: ");
                            int id = int.Parse(Console.ReadLine());
                            Vendedor vendedor = vendedores.OsVendedores.FirstOrDefault(vend => vend != null && vend.Id == id);
                            int dia;
                            
                            if(vendedor != null)
                            {
                                do
                                {
                                    Console.WriteLine("Digite o dia da venda: ");
                                    dia = int.Parse(Console.ReadLine());
                                    if (dia < 1 || dia > 30)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("!!!Erro: Dia inválido, necessário digitar um dia entre 1 a 30");
                                        Console.ResetColor();
                                    }
                                } while (dia < 1 || dia > 30);
                                
                                Console.WriteLine("Digite a Quantidade de vendas: ");
                                int qtde = int.Parse(Console.ReadLine());

                                Console.WriteLine("Valor da Venda: ");
                                double valorVenda = double.Parse(Console.ReadLine());

                                Venda venda = new Venda(qtde, valorVenda);                                                                
                                vendedor.registrarVenda(dia, venda);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nVenda Registrada com Sucesso!!!\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n!!!Erro: Não foi possível achar o vendedor!\n");
                                Console.ResetColor();
                            }                  
                            break;
                        }
                    case 5:
                        {
                            // Listar vendedores
                            foreach(var v in vendedores.OsVendedores)
                            {
                                if(v != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n" + v.dadosVendedor());
                                }                                
                            }
                            Console.WriteLine("Valor total das Vendas de todos vendedores: " + vendedores.valorVendas());
                            Console.WriteLine("Valor total a pagar de comissão para todos funcionários: " + vendedores.valorComissao());
                            Console.ResetColor();
                            break;
                        }
                    default:
                        {
                            if (valor != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nValor inválido! \n");
                                Console.ResetColor();
                            }
                            break;
                        }
                }
            } while (valor != 0);
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine("\nProgama encerrado!");
            Console.ResetColor();
        }
    }
}

