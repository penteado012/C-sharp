using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Listas_Biblioteca
{
        internal class Program
        {
            static Livros biblioteca = new Livros();

            static void Main(string[] args)
            {
                bool sair = false;
                while (!sair)
                {
                    Console.Clear();
                    Console.WriteLine("========== BIBLIOTECA (POO) ==========");
                    Console.WriteLine("0 - Sair");
                    Console.WriteLine("1 - Adicionar livro");
                    Console.WriteLine("2 - Pesquisar livro (sintético)");
                    Console.WriteLine("3 - Pesquisar livro (analítico)");
                    Console.WriteLine("4 - Adicionar exemplar");
                    Console.WriteLine("5 - Registrar empréstimo");
                    Console.WriteLine("6 - Registrar devolução");
                    Console.WriteLine("======================================");
                    Console.Write("Opção: ");
                    string opc = Console.ReadLine();

                    switch (opc)
                    {
                        case "0":
                            sair = true;
                            break;
                        case "1":
                            AdicionarLivro();
                            break;
                        case "2":
                            PesquisarSintetico();
                            break;
                        case "3":
                            PesquisarAnalitico();
                            break;
                        case "4":
                            AdicionarExemplar();
                            break;
                        case "5":
                            RegistrarEmprestimo();
                            break;
                        case "6":
                            RegistrarDevolucao();
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Enter para continuar...");
                            Console.ReadLine();
                            break;
                    }
                }
            }
            
            static void AdicionarLivro()
            {
                Console.Clear();
                Console.WriteLine("=== Adicionar Livro ===");
                Console.Write("ISBN (número): ");
                if (!int.TryParse(Console.ReadLine(), out int isbn))
                {
                    Console.WriteLine("ISBN inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                if (biblioteca.pesquisar(isbn) != null)
                {
                    Console.WriteLine("Já existe livro com esse ISBN no acervo. Enter...");
                    Console.ReadLine();
                    return;
                }

                Console.Write("Título: ");
                string titulo = Console.ReadLine() ?? "";
                Console.Write("Autor: ");
                string autor = Console.ReadLine() ?? "";
                Console.Write("Editora: ");
                string editora = Console.ReadLine() ?? "";

                Livro novo = new Livro(isbn, titulo, autor, editora);
                biblioteca.adicionar(novo);

                Console.WriteLine("Livro adicionado com sucesso! Enter...");
                Console.ReadLine();
            }

            static void PesquisarSintetico()
            {
                Console.Clear();
                Console.WriteLine("=== Pesquisa Sintética ===");
                Console.Write("ISBN do livro: ");
                if (!int.TryParse(Console.ReadLine(), out int isbn))
                {
                    Console.WriteLine("ISBN inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                Livro l = biblioteca.pesquisar(isbn);
                if (l == null)
                {
                    Console.WriteLine("Livro não encontrado. Enter...");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("----- Resultado Sintético -----");
                Console.WriteLine($"Título: {l.Titulo}");
                Console.WriteLine($"Autor: {l.Autor}");
                Console.WriteLine($"Editora: {l.Editora}");
                Console.WriteLine($"ISBN: {l.Isbn}");
                Console.WriteLine($"Total exemplares: {l.qtdeExemplares()}");
                Console.WriteLine($"Exemplares disponíveis: {l.qtdeDisponiveis()}");
                Console.WriteLine($"Total de empréstimos: {l.qtdeEmprestimos()}");
                Console.WriteLine($"Percentual disponibilidade: {l.percDisponibilidade():0.##}%");

                Console.WriteLine("Enter pra voltar...");
                Console.ReadLine();
            }

            static void PesquisarAnalitico()
            {
                Console.Clear();
                Console.WriteLine("=== Pesquisa Analítica ===");
                Console.Write("ISBN do livro: ");
                if (!int.TryParse(Console.ReadLine(), out int isbn))
                {
                    Console.WriteLine("ISBN inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                Livro l = biblioteca.pesquisar(isbn);
                if (l == null)
                {
                    Console.WriteLine("Livro não encontrado. Enter...");
                    Console.ReadLine();
                    return;
                }

                Console.WriteLine("----- Resultado Analítico -----");
                Console.WriteLine(l.ToString());
                Console.WriteLine();

                if (l.Exemplares.Count == 0)
                {
                    Console.WriteLine("Nenhum exemplar cadastrado para este livro.");
                    Console.WriteLine("Enter...");
                    Console.ReadLine();
                    return;
                }

                for (int i = 0; i < l.Exemplares.Count; i++)
                {
                    Exemplar ex = l.Exemplares[i];
                    Console.WriteLine($"Exemplar #{i + 1}: {ex.ToString()}");

                    IList<Emprestimo> lista = TryGetEmprestimos(ex);
                    if (lista == null || lista.Count == 0)
                    {
                        Console.WriteLine("  (Sem registros de empréstimo)");
                    }
                    else
                    {
                        for (int j = 0; j < lista.Count; j++)
                        {
                            Emprestimo emp = lista[j];
                            string devol = (emp.dtDevolucao == DateTime.MinValue) ? "Ainda não devolvido" : emp.dtDevolucao.ToString();
                            Console.WriteLine($"  Empr#{j + 1}: {emp.dtEmprestimo} | Devolução: {devol}");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Enter pra voltar...");
                Console.ReadLine();
            }

            static void AdicionarExemplar()
            {
                Console.Clear();
                Console.WriteLine("=== Adicionar Exemplar ===");
                Console.Write("ISBN do livro: ");
                if (!int.TryParse(Console.ReadLine(), out int isbn))
                {
                    Console.WriteLine("ISBN inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                Livro l = biblioteca.pesquisar(isbn);
                if (l == null)
                {
                    Console.WriteLine("Livro não encontrado. Cadastre o livro primeiro. Enter...");
                    Console.ReadLine();
                    return;
                }

                Console.Write("Tombo (número do exemplar): ");
                if (!int.TryParse(Console.ReadLine(), out int tombo))
                {
                    Console.WriteLine("Tombo inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                foreach (var ex in l.Exemplares)
                {
                    int? t = TryExtractTomboFromToString(ex.ToString());
                    if (t != null && t.Value == tombo)
                    {
                        Console.WriteLine("Já existe exemplar com esse tombo. Enter...");
                        Console.ReadLine();
                        return;
                    }
                }

                Exemplar novo = new Exemplar(tombo);
                l.adicionarExemplar(novo);

                Console.WriteLine("Exemplar adicionado com sucesso! Enter...");
                Console.ReadLine();
            }

            static void RegistrarEmprestimo()
            {
                Console.Clear();
                Console.WriteLine("=== Registrar Empréstimo ===");
                Console.Write("ISBN do livro: ");
                if (!int.TryParse(Console.ReadLine(), out int isbn))
                {
                    Console.WriteLine("ISBN inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                Livro l = biblioteca.pesquisar(isbn);
                if (l == null)
                {
                    Console.WriteLine("Livro não encontrado. Enter...");
                    Console.ReadLine();
                    return;
                }

                Exemplar exemplarDisponivel = null;
                foreach (var ex in l.Exemplares)
                {
                    if (ex.disponivel())
                    {
                        exemplarDisponivel = ex;
                        break;
                    }
                }

                if (exemplarDisponivel == null)
                {
                    Console.WriteLine("Nenhum exemplar disponível para empréstimo. Enter...");
                    Console.ReadLine();
                    return;
                }

                bool ok = exemplarDisponivel.emprestar();
                Console.WriteLine(ok ? "Empréstimo registrado com sucesso!" : "Falha ao registrar empréstimo.");
                Console.WriteLine("Enter...");
                Console.ReadLine();
            }

            static void RegistrarDevolucao()
            {
                Console.Clear();
                Console.WriteLine("=== Registrar Devolução ===");
                Console.Write("ISBN do livro: ");
                if (!int.TryParse(Console.ReadLine(), out int isbn))
                {
                    Console.WriteLine("ISBN inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                Livro l = biblioteca.pesquisar(isbn);
                if (l == null)
                {
                    Console.WriteLine("Livro não encontrado. Enter...");
                    Console.ReadLine();
                    return;
                }

                Console.Write("Tombo do exemplar a devolver: ");
                if (!int.TryParse(Console.ReadLine(), out int tombo))
                {
                    Console.WriteLine("Tombo inválido. Enter...");
                    Console.ReadLine();
                    return;
                }

                Exemplar alvo = null;
                foreach (var ex in l.Exemplares)
                {
                    int? t = TryExtractTomboFromToString(ex.ToString());
                    if (t != null && t.Value == tombo)
                    {
                        alvo = ex;
                        break;
                    }
                }

                if (alvo == null)
                {
                    Console.WriteLine("Exemplar não encontrado (verifique o tombo). Enter...");
                    Console.ReadLine();
                    return;
                }

                bool ok = alvo.devolver();
                Console.WriteLine(ok ? "Devolução registrada com sucesso!" : "Falha: exemplar já disponível.");
                Console.WriteLine("Enter...");
                Console.ReadLine();
            }
            
        
            static int? TryExtractTomboFromToString(string s)
            {
                if (string.IsNullOrEmpty(s)) return null;

                string token = "Tombo:";
                int p = s.IndexOf(token, StringComparison.OrdinalIgnoreCase);
                if (p < 0) return null;
                int start = p + token.Length;
                int comma = s.IndexOf(',', start);
                string numstr = (comma >= 0) ? s.Substring(start, comma - start) : s.Substring(start);
                if (int.TryParse(numstr.Trim(), out int tombo)) return tombo;
                return null;
            }

            static IList<Emprestimo> TryGetEmprestimos(Exemplar ex)
            {
                if (ex == null) return null;

                Type t = ex.GetType();

                PropertyInfo prop = t.GetProperty("Emprestimos", BindingFlags.Public | BindingFlags.Instance);
                if (prop != null)
                {
                    object val = prop.GetValue(ex);
                    if (val is IList<Emprestimo> listProp) return listProp;
                }

                FieldInfo field = t.GetField("emprestimos", BindingFlags.NonPublic | BindingFlags.Instance);
                if (field != null)
                {
                    object val = field.GetValue(ex);
                    if (val is IList<Emprestimo> listField) return listField;
                }

                return null;
            }
        }
    }

