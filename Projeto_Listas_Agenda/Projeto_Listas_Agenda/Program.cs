using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Projeto_Listas_Agenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contatos contatos = new Contatos();
            int opcao;

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("| 0. Sair                            |");
                Console.WriteLine("| 1. Adicionar contato               |");
                Console.WriteLine("| 2. Pesquisar contato               |");
                Console.WriteLine("| 3. Alterar contato                 |");
                Console.WriteLine("| 4. Remover contato                 |");
                Console.WriteLine("| 5. Listar contatos                 |");
                Console.WriteLine("--------------------------------------");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nPrograma encerrado!");
                        break;
                    case 1:
                        string email;
                        Console.WriteLine("Digite seu email:");

                        while (true)
                        {
                            email = Console.ReadLine();
                            try
                            {
                                MailAddress m = new MailAddress(email);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Email inválido! Digite um email válido:");
                            }
                        }

                        Console.WriteLine("Digite seu nome: ");
                        string nome = Console.ReadLine();

                        int dia;
                        Console.WriteLine("Digite o dia que você nasceu: ");                        
                        while (!int.TryParse(Console.ReadLine(), out dia))
                        {
                            Console.WriteLine("Entrada inválida! Digite um número inteiro:");
                        }

                        int mes;
                        Console.WriteLine("Digite o mês que você nasceu: ");
                        while (!int.TryParse(Console.ReadLine(), out mes))
                        {
                            Console.WriteLine("Entrada inválida! Digite um número inteiro:");
                        }

                        int ano;
                        Console.WriteLine("Digite o ano que você nasceu: ");                      
                        while (!int.TryParse(Console.ReadLine(), out ano))
                        {
                            Console.WriteLine("Entrada inválida! Digite um número inteiro:");
                        }

                        Data data = new Data();
                        data.setData(dia, mes, ano);

                        Console.WriteLine("Digite seu tipo de telefone: ");
                        string tipo = Console.ReadLine();

                        Console.WriteLine("Digite seu numero de telefone: ");
                        string numeroTel = Console.ReadLine();

                        Contato contato = new Contato(email, nome, data);
                        Telefone telefone = new Telefone(tipo, numeroTel, true);

                        contato.adicionarTelefone(telefone);

                        Console.WriteLine((contatos.adicionar(contato)) ? "Contato Adicionado com Sucesso!" : "Já existe contato com esse email!");
                        break;
                    case 2:
                        string email1;
                        Console.WriteLine("Digite o email do contato que deseja pesquisar: ");
                        while (true)
                        {
                            email1 = Console.ReadLine();
                            try
                            {
                                MailAddress m = new MailAddress(email1);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Email inválido! Digite um email válido:");
                            }
                        }

                        Contato contato1 = new Contato {Email = email1 };
                        Contato cttencontrado = contatos.pesquisar(contato1);

                        if (cttencontrado != null)
                            Console.WriteLine(cttencontrado.ToString());
                        else
                            Console.WriteLine("Nenhum contato encontrado com esse email!");
                            break;
                    case 3:
                        string email2;
                        Console.WriteLine("Digite o email do contato que deseja alterar: ");
                        while (true)
                        {
                            email2 = Console.ReadLine();
                            try
                            {
                                MailAddress m = new MailAddress(email2);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Email inválido! Digite um email válido:");
                            }
                        }

                        Contato contato2 = contatos.Agenda.FirstOrDefault(c => c.Email == email2);

                        if (contato2 != null)
                        {
                            Console.Write("Digite o novo nome (ou ENTER para manter o atual): ");
                            string novoNome = Console.ReadLine();
                            if (!string.IsNullOrEmpty(novoNome))
                                contato2.Nome = novoNome;

                            Console.WriteLine("Deseja alterar a data de nascimento? (s/n)");
                            string resp = Console.ReadLine();
                            if (resp.ToLower() == "s")
                            {
                                Console.Write("Dia: ");
                                int dia1 = int.Parse(Console.ReadLine());
                                Console.Write("Mês: ");
                                int mes1 = int.Parse(Console.ReadLine());
                                Console.Write("Ano: ");
                                int ano1 = int.Parse(Console.ReadLine());
                                contato2.DtNasc.setData(dia1, mes1, ano1);
                            }

                            Console.WriteLine("Deseja alterar o telefone principal? (s/n)");
                            resp = Console.ReadLine();
                            if (resp.ToLower() == "s")
                            {
                                if (contato2.Telefones.Count == 0)
                                {
                                    Console.Write("Tipo do telefone: ");
                                    string tipo1 = Console.ReadLine();
                                    Console.Write("Número: ");
                                    string numero = Console.ReadLine();
                                    Telefone t = new Telefone(tipo1, numero, true);
                                    contato2.adicionarTelefone(t);
                                }
                                else
                                {
                                    Console.WriteLine("Telefones cadastrados:");
                                    for (int i = 0; i < contato2.Telefones.Count; i++)
                                    {
                                        Console.WriteLine($"{i + 1}. {contato2.Telefones[i].Tipo} - {contato2.Telefones[i].Numero}" +
                                                          (contato2.Telefones[i].Principal ? " (Principal)" : ""));
                                    }

                                    Console.Write("Escolha o número do telefone que será principal: ");
                                    int escolha = int.Parse(Console.ReadLine()) - 1;

                                    for (int i = 0; i < contato2.Telefones.Count; i++)
                                    {
                                        contato2.Telefones[i].Principal = (i == escolha);
                                    }
                                }
                            }

                            Console.WriteLine("Contato alterado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("ERRO!!! Não existe contato com esse email!");
                        }
                        break;
                    case 4:
                        string email3;
                        Console.WriteLine("Digite o email do contato que deseja remover: ");
                        while (true)
                        {
                            email3 = Console.ReadLine();
                            try
                            {
                                MailAddress m = new MailAddress(email3);
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Email inválido! Digite um email válido:");
                            }
                        }

                        Contato contato3 = new Contato {Email = email3 };

                        Console.WriteLine(contatos.remover(contato3)? "Contato excluído com sucesso!" : "ERRO!!! Email do contato não existente!");
                        break;
                    case 5:
                        int e = 1;
                        foreach (Contato c in contatos.Agenda)
                        {
                            if(c != null)
                            {
                                Console.WriteLine($"Contato: {e++}\n");
                                Console.WriteLine(c.ToString());
                            }
                        }
                        break; 
                    default:
                        Console.WriteLine("ERRO!!! Número Inválido!");
                        break;
                }


            } while (opcao != 0);
        }
    }
}
