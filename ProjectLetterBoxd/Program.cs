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
                    string opcao = Console.ReadLine();

                    

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("Digite o nome do filme: ");
                            string? nome = Console.ReadLine();
                            Console.Write("Qual seu diretor: ");
                            string? diretor = Console.ReadLine();
                            Console.Write("Ano de lançamento: ");
                            int ano = int.Parse(Console.ReadLine());
                            Console.Write("Quantas estrelas você daria para o filme (1 a 5): ");
                            Enum estrelas = (Estrelas)int.Parse(Console.ReadLine());
                            metodos.AdicionarFilme(nome, diretor, ano, estrelas);
                            Console.WriteLine();
                            break;

                        case "2":

                            metodos.ListarFilmes();
                            Console.WriteLine();

                            break;

                        case "3":
                            Console.Write("Nome do filme a ser removido: ");
                            string nomeRemover = Console.ReadLine();
                            metodos.RemoverFilme(nomeRemover);
                            break;

                        case "4":
                            Console.Write("Difite o nome do filme a ser pesquisado: ");
                            string nomeDoFilme = Console.ReadLine();
                            metodos.PesquisarPorFilme(nomeDoFilme);
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
