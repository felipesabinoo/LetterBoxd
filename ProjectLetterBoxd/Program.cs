using System;
using Filmes;
using System.Collections.Generic;
using System.Linq;


namespace ProjectLetterBoxd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COLEÇÂO DE FILMES DO USUÁRIO.");
            Console.WriteLine();
            try
            {
                MetodosDosFilmes metodos = new MetodosDosFilmes();

                while (true)
                {
                    Console.WriteLine("Digite o número correspondente a ação desejada: ");
                    Console.WriteLine();
                    Console.WriteLine("1 - Adicionar filme");
                    Console.WriteLine("2 - Listar filmes");
                    Console.WriteLine("3 - Remover filme");
                    Console.WriteLine("4 - Pesquisar por filme");
                    Console.WriteLine("5 - Pesquisar por diretor");
                    Console.WriteLine("6 - Ranquear filmes por estrelas");
                    Console.WriteLine("0 - Sair");
                    Console.WriteLine();
                    Console.Write("Opção: ");
                    string? opcao = Console.ReadLine();

                    if (opcao == null)
                    {
                        Console.WriteLine("Entrada inválida. Por favor, tente novamente.");
                        continue;
                    }

                    switch (opcao)
                    {
                        case "1":

                            Console.WriteLine("Conte me mais sobre esse filme:");
                            metodos.AdicionarFilme();
                            Console.WriteLine();
                            break;

                        case "2":

                            metodos.ListarFilmes();
                            Console.WriteLine();

                            break;

                        case "3":
                            
                            metodos.RemoverFilme();
                            break;

                        case "4":
                            
                            metodos.PesquisarPorFilme();
                            break;

                        case "5":
                            
                            metodos.PesquisarPorDiretor();
                            break;

                        case "6":
                            Console.WriteLine("Ranking dos filmes por estrelas: ");
                            metodos.RanquearFilmes();
                            Console.WriteLine();
                            break;

                        case "0":
                            Console.WriteLine("Saindo...");
                            return;

                        default:
                            Console.WriteLine("Opção inválida. Por Favor, tente novamente.");
                            break;
                    }

                }
            }
            catch (ExceptionFilmes e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
