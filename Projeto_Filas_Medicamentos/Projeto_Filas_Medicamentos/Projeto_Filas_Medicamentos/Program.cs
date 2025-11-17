using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) 
                {
                    case 0:
                        Console.WriteLine("Sessão Finalizada!");
                        break;
                    case 1: // Cadastrar medicamento
                        Console.WriteLine("Digite o id para cadastro: ");
                        int idCadastro = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o nome do seu medicamento: ");
                        string nomeMedicamento = Console.ReadLine();

                        Console.WriteLine("Digite o nome do seu laboratorio: ");
                        string nomeLaboratorio = Console.ReadLine();

                        Medicamento medicamento = new Medicamento(idCadastro, nomeMedicamento, nomeLaboratorio);
                        medicamentos.adicionar(medicamento);
                        Console.WriteLine("Medicamento cadastrado com sucesso!");                        
                        break;

                    case 2: // Consultar medicamento (sintético)
                        Console.WriteLine("Digite o id do medicamento que deseja consultar:");
                        int consultaMedicamento = int.Parse(Console.ReadLine());

                        Medicamento medicamento1 = new Medicamento {Id = consultaMedicamento };
                        Medicamento mPesquisa = medicamentos.pesquisar(medicamento1);

                        if(mPesquisa == null)
                        {
                            Console.WriteLine("Nenhum medicamento foi encontrado com esse id.");
                        } else
                        {
                            Console.WriteLine(mPesquisa.ToString());
                        }
                        break;

                    case 3: // Consultar medicamento (analítico)
                        break;

                    case 4: // Comprar medicamento (cadastrar lote)
                        break;

                    case 5: // Vender medicamento (abater do lote mais antigo)
                        break;

                    case 6: // Listar medicamentos (dados sintéticos)
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opcao != 0);

        }
    }
}
