using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Filas_Acessos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cadastro cadastro = new Cadastro();

            // Cria o banco e as tabelas (apenas na primeira execução)
            cadastro.upload();

            // Baixar os dados existentes do banco
            cadastro.download();

            int opcao = -1;

            do
            {
                Console.WriteLine("====================================");
                Console.WriteLine(" 0. Sair");
                Console.WriteLine(" 1. Cadastrar ambiente");
                Console.WriteLine(" 2. Consultar ambiente");
                Console.WriteLine(" 3. Excluir ambiente");
                Console.WriteLine(" 4. Cadastrar usuario");
                Console.WriteLine(" 5. Consultar usuario");
                Console.WriteLine(" 6. Excluir usuario");
                Console.WriteLine(" 7. Conceder permissao ao usuario");
                Console.WriteLine(" 8. Revogar permissao do usuario");
                Console.WriteLine(" 9. Registrar acesso");
                Console.WriteLine("10. Consultar logs de acesso");
                Console.WriteLine("====================================");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    continue;
                }

                Console.Clear();

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    case 1:
                        Console.WriteLine("Cadastrar ambiente");
                        Console.WriteLine("Digite o nome do seu ambiente: ");
                        string nAmbiente = Console.ReadLine();

                        Ambiente ambiente = new Ambiente { Name = nAmbiente };
                        cadastro.adicionarAmbiente(ambiente);
                        cadastro.SalvarAmbiente(ambiente);
                        Console.WriteLine("Ambiente cadastrado com sucesso!");
                        break;

                    case 2:
                        Console.WriteLine("Consultar ambiente");
                        Console.Write("Digite o ID do ambiente que deseja consultar: ");
                        int idAmbiente1 = Convert.ToInt32(Console.ReadLine());

                        Ambiente ambiente1 = new Ambiente { Id = idAmbiente1 };

                        Ambiente ambientePesquisa = cadastro.pesquisarAmbiente(ambiente1);

                        if (ambientePesquisa == null)
                        {
                            Console.WriteLine("ERRO!!! Nenhum ambiente com esse ID!");
                        }
                        else
                        {
                            Console.WriteLine($"Ambiente consultado: \n Nome: {ambientePesquisa.Name} \n Id: {ambientePesquisa.Id}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Excluir ambiente");
                        Console.Write("Digite o ID do ambiente que deseja excluir: ");
                        int idAmbiente2 = Convert.ToInt32(Console.ReadLine());

                        Ambiente ambiente2 = new Ambiente { Id = idAmbiente2 };
                        Ambiente ambientePesquisa2 = cadastro.pesquisarAmbiente(ambiente2);

                        if (ambientePesquisa2 == null)
                        {
                            Console.WriteLine("ERRO!!! Nenhum ambiente com esse ID!");
                        }
                        else
                        {
                            if (!cadastro.removerAmbiente(ambientePesquisa2))
                            {
                                Console.WriteLine("ERRO!!! Existe usuário com permissão nesse ambiente!");
                            }
                            else
                            {
                                Console.WriteLine("Ambiente removido com sucesso!!!");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Cadastrar usuário");
                        Console.Write("Digite o nome do usuário: ");
                        string nUsuario = Console.ReadLine();

                        Usuario usuario = new Usuario { Name = nUsuario };
                        cadastro.adicionarUsuario(usuario);
                        cadastro.SalvarUsuario(usuario);

                        Console.WriteLine("Usuário cadastrado com sucesso!!!");
                        break;

                    case 5:
                        Console.WriteLine("Consultar usuário");
                        Console.WriteLine("Digite o id do usuário: ");
                        int idUsuario = Convert.ToInt32(Console.ReadLine());
                        Usuario usuario1 = new Usuario {Id = idUsuario };

                        Usuario usuarioPesquisa1 = cadastro.pesquisarUsuario(usuario1);
                        if(usuarioPesquisa1 == null)
                        {
                            Console.WriteLine("ERRO!!! Não existe usuario com esse id!");
                        }
                        else
                        {
                            Console.WriteLine($"Nome: {usuarioPesquisa1.Name} \n Id: {usuarioPesquisa1.Id}");
                        }                        
                        break;

                    case 6:
                        Console.WriteLine("Excluir usuário");
                        Console.WriteLine("Digite o id do usuário: ");
                        int idUsuario2 = Convert.ToInt32(Console.ReadLine());

                        Usuario usuario2 = new Usuario { Id = idUsuario2 };
                        Usuario usuarioPesquisa2 = cadastro.pesquisarUsuario(usuario2);

                        if(usuarioPesquisa2 == null)
                        {
                            Console.WriteLine("ERRO!! Não existe usuario com esse id!");
                        }
                        else if(!cadastro.removerUsuario(usuarioPesquisa2))
                        {
                            Console.WriteLine("ERRO!!! Este usuario contem permissao de acesso!");
                        }
                        else
                        {
                            Console.WriteLine("Usuario removido com sucesso!!!");
                        }
                            break;
                    case 7:
                        Console.WriteLine("Conceder permissão de acesso");
                        Console.WriteLine("Digite o id do usuario: ");
                        int idUsuario3 = Convert.ToInt32(Console.ReadLine());

                        Usuario usuario3 = new Usuario { Id = idUsuario3 };
                        Usuario usuarioPesquisa3 = cadastro.pesquisarUsuario(usuario3);
                        if(usuarioPesquisa3 == null)
                        {
                            Console.WriteLine("ERRO!! Não existe usuario com esse id!");
                        } else
                        {
                            Console.Write("Digite o ID do ambiente: ");
                            int idAmbiente3 = Convert.ToInt32(Console.ReadLine());

                            Ambiente ambiente3 = new Ambiente { Id = idAmbiente3 };

                            Ambiente ambientePesquisa3 = cadastro.pesquisarAmbiente(ambiente3);

                            if (ambientePesquisa3 == null)
                            {
                                Console.WriteLine("ERRO!!! Nenhum ambiente com esse ID!");
                            }
                            else
                            {
                                if (usuarioPesquisa3.concederPermissao(ambientePesquisa3))
                                {
                                    cadastro.SalvarPermissao(usuarioPesquisa3, ambientePesquisa3);
                                    Console.WriteLine("Permissao de acesso concedida com sucesso!");
                                } else
                                {
                                    Console.WriteLine("ERRO!!! O usuario ja tem permissao concedida!");
                                }
                            }
                        }
                            break;
                    case 8:
                        Console.WriteLine("Revogar permissão de acesso");
                        Console.WriteLine("Digite o id do usuario: ");
                        int idUsuario4 = Convert.ToInt32(Console.ReadLine());

                        Usuario usuario4 = new Usuario { Id = idUsuario4 };
                        Usuario usuarioPesquisa4 = cadastro.pesquisarUsuario(usuario4);
                        if (usuarioPesquisa4 == null)
                        {
                            Console.WriteLine("ERRO!! Não existe usuario com esse id!");
                        }
                        else
                        {
                            Console.Write("Digite o ID do ambiente: ");
                            int idAmbiente4 = Convert.ToInt32(Console.ReadLine());

                            Ambiente ambiente4 = new Ambiente { Id = idAmbiente4 };

                            Ambiente ambientePesquisa4 = cadastro.pesquisarAmbiente(ambiente4);

                            if (ambientePesquisa4 == null)
                            {
                                Console.WriteLine("ERRO!!! Nenhum ambiente com esse ID!");
                            }
                            else
                            {
                                if (usuarioPesquisa4.revogarPermissao(ambientePesquisa4))
                                {
                                    cadastro.RemoverPermissao(usuarioPesquisa4, ambientePesquisa4);
                                    Console.WriteLine("Permissao de acesso revogada com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("ERRO!! O usuário não possuía permissão para esse ambiente!");
                                }
                            }
                        }
                        break;
                    case 9:
                        Console.WriteLine("Registrar acesso");

                        Console.Write("Digite o ID do usuário: ");
                        int idUsuario5 = Convert.ToInt32(Console.ReadLine());

                        Usuario usuario5 = cadastro.pesquisarUsuario(new Usuario { Id = idUsuario5 });
                        if (usuario5 == null)
                        {
                            Console.WriteLine("ERRO!! Não existe usuário com esse ID!");
                            break;
                        }

                        Console.Write("Digite o ID do ambiente: ");
                        int idAmbiente5 = Convert.ToInt32(Console.ReadLine());

                        Ambiente ambiente5 = cadastro.pesquisarAmbiente(new Ambiente { Id = idAmbiente5 });
                        if (ambiente5 == null)
                        {
                            Console.WriteLine("ERRO!! Não existe ambiente com esse ID!");
                            break;
                        }

                        Log log = new Log();
                        log.DtAcesso = DateTime.Now;
                        log.Usuario = usuario5;
                        bool autorizado = usuario5.Ambientes.Contains(ambiente5);
                        log.TipoAcesso = autorizado;

                        if (autorizado)
                        {
                            ambiente5.registrarLog(log);
                            Console.WriteLine("Acesso autorizado e registrado!");
                        }
                        else
                        {
                            Console.WriteLine("Acesso NEGADO e registrado!");
                        }
                        cadastro.SalvarLog(log, ambiente5);
                        break;
                    case 10:
                        Console.WriteLine("Consultar logs de acesso");
                        Console.WriteLine("Digite o id do ambiente: ");
                        int idAmbiente6 = Convert.ToInt32(Console.ReadLine());
                        
                        Ambiente ambiente6 = new Ambiente {Id = idAmbiente6 };
                        Ambiente ambientePesquisa5 = cadastro.pesquisarAmbiente(ambiente6);
                        if (ambientePesquisa5 == null)
                        {
                            Console.WriteLine("ERRO!!! Id inválido!");
                            break;
                        }

                        Console.WriteLine("\nEscolha o filtro:");
                        Console.WriteLine("1 - Apenas autorizados");
                        Console.WriteLine("2 - Apenas negados");
                        Console.WriteLine("3 - Todos");
                        Console.Write("Opção: ");
                        int filtro = Convert.ToInt32(Console.ReadLine());

                        foreach (Log logItem in ambientePesquisa5.Logs)
                        {
                            bool mostrar = false;

                            if(filtro == 1 && logItem.TipoAcesso)
                            {
                                mostrar = true;
                            } else if (filtro == 2 && !logItem.TipoAcesso)
                            {
                                mostrar = true;
                            }else if (filtro ==3)
                            {
                                mostrar = true;
                            }

                            if (mostrar)
                            {
                                string status = logItem.TipoAcesso ? "Autorizado" : "Negado";
                                Console.WriteLine($"{logItem.DtAcesso} - Usuário: {logItem.Usuario.Name} - {status}");
                            }
                        }
                            break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (opcao != 0);
        }
    }
}