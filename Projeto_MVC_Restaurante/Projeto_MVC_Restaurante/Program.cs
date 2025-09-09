using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MVC_Restaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante();
            int opcao;
            do
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Criar novo pedido");
                Console.WriteLine("2. Adicionar item ao pedido");
                Console.WriteLine("3. Remover item do pedido");
                Console.WriteLine("4. Consultar pedido");
                Console.WriteLine("5. Cancelar pedido");
                Console.WriteLine("6. Listar todos os pedidos");
                Console.Write("Escolha uma opção: ");
                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro:");
                }
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Programa Encerrado!");
                        break;
                    case 1:
                        Console.WriteLine("Digite seu nome: ");
                        string nome = Console.ReadLine();
                        Pedido pedido = new Pedido();
                        pedido.Cliente = nome;
                        Console.WriteLine(restaurante.novoPedido(pedido) ? "Pedido Criado com sucesso" : "Erro! Máximo de pedido já feitos!");                        
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do item: ");
                        string nomeItem = Console.ReadLine();
                        Console.WriteLine("Digite o valor do item: ");
                        int valorItem = int.Parse(Console.ReadLine());

                        Item item = new Item { Descricao = nomeItem, Preco = valorItem };  
                        Console.WriteLine("Digite o id do pedido que deseja adicionar o item: ");
                        int idPedido = int.Parse(Console.ReadLine());

                        Pedido pedido1 = restaurante.buscarPedido(new Pedido {Id = idPedido });
                        if(pedido1 != null)
                        {
                            Console.WriteLine(pedido1.adcionarItem(item) ? "Pedido Adicionado com sucesso!" : "ERRO!!! Máximo de itens excedido no pedido");                           
                        }
                        else
                        {
                            Console.WriteLine("Não existe pedido com esse id");
                        }                            
                        break;
                    case 3:                        
                        Console.WriteLine("Digite o id do item que deseja remover: ");
                        int idItem = int.Parse(Console.ReadLine());
                        bool itemRemovido = false;
                        foreach(var p in restaurante.Pedidos)
                        {  
                            if(p != null)
                            {
                                foreach (var i in p.Items)
                                {
                                    if(i != null && i.Id == idItem)
                                    {
                                        if (p.removerItem(i))
                                        {
                                            Console.WriteLine("Item removido com sucesso!");
                                            itemRemovido = true;
                                            break;
                                        }
                                    }
                                }
                                if (itemRemovido)
                                {
                                    break;
                                }
                            }
                        }
                        if (!itemRemovido)
                        {
                            Console.WriteLine("Nenhum item foi encontrado com esse id!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Digite o id do pedido que deseja consultar: ");
                        int idPedido1 = int.Parse(Console.ReadLine());

                        Pedido pedido2 = restaurante.buscarPedido(new Pedido {Id = idPedido1 });
                        if (pedido2 != null)
                        {
                            Console.WriteLine(pedido2.dadosDoPedido());
                        }
                        else
                        {
                            Console.WriteLine("Não existe pedido com esse id");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Digite o id do pedido que deseja cancelar: ");
                        int idPedido2 = int.Parse(Console.ReadLine());

                        Pedido pedido3 = restaurante.buscarPedido(new Pedido {Id = idPedido2});
                        if(pedido3 != null && restaurante.cancelarPedido(pedido3))
                        {
                            Console.WriteLine("Pedido cancelado com sucesso!");
                        } else
                        {
                            Console.WriteLine("ERRO!!! Não existe pedido com esse id!");
                        }
                            break;
                    case 6:
                        bool tempedido = false;
                        double valorTotal = 0;
                        Console.WriteLine("Lista de Todos os Pedidos!\n");
                        foreach (var p in restaurante.Pedidos)
                        {
                            if(p != null)
                            {
                                Console.WriteLine($"ID: {p.Id} Valor total do pedido: {p.calcularTotal()}");
                                valorTotal += p.calcularTotal();
                                tempedido = true;
                            }
                        }
                        if (!tempedido)
                        {
                            Console.WriteLine("Não tem pedidos!");
                        }
                        else
                        {
                            Console.WriteLine($"Soma geral do dia: {valorTotal}");
                        }
                            break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao!= 0);
        }
    }
}
