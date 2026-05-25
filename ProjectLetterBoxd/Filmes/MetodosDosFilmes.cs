using System;
using System.Linq;
using System.Collections.Generic;


namespace Filmes
{
    internal class MetodosDosFilmes
    {

        public List<Filmes> filmes = new List<Filmes>();

        public MetodosDosFilmes()
        {
        }

        public void AdicionarFilme()
        {
            Console.Write("Digite o nome do filme: ");
            string? nome = Console.ReadLine();
            Console.Write("Qual seu diretor: ");
            string? diretor = Console.ReadLine();
            Console.Write("Ano de lançamento: ");
            if (!int.TryParse(Console.ReadLine(), out int ano))
            {
                Console.WriteLine("Ano inválido.");
                return;
            }
            Console.Write("Quantas estrelas você daria para o filme (1 a 5): ");
            if (!int.TryParse(Console.ReadLine(), out int estrelasInt) || estrelasInt < 1 || estrelasInt > 5)
            {
                Console.WriteLine("Estrelas inválidas.");
                return;
            }

            Estrelas estrelas = (Estrelas)estrelasInt;
            filmes.Add(new Filmes(nome, diretor, ano, estrelas));
            Console.WriteLine($"Filme adicionado com sucesso.");
        }

        public void ListarFilmes()
        {
            if (filmes.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");

            }
            else
            {
                Console.WriteLine("Lista dos filmes!");
                var filmesOrdenados = filmes.OrderBy(f => f.Nome).ToList();
                foreach (var filme in filmesOrdenados)
                {
                    ExibirFilme(filme);
                }
            }
        }

        public void RemoverFilme()
        {
            Console.Write("Nome do filme a ser removido: ");
            string Nome = Console.ReadLine() ?? "";
            var filmeARemover = filmes.Find(f => f.Nome.Equals(Nome, StringComparison.OrdinalIgnoreCase));
            if (filmeARemover != null)
            {
                filmes.Remove(filmeARemover);
                Console.WriteLine($"Filme '{filmeARemover.Nome}' removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Filme '{Nome}' não encontrado.");
            }

        }

        public void PesquisarPorFilme()
        {
            Console.Write("Nome do filme a ser pesquisado: ");
            string Nome = Console.ReadLine() ?? "";
            var filmePesquisado = filmes.Find(f => f.Nome.Equals(Nome, StringComparison.OrdinalIgnoreCase));
            if (filmePesquisado != null)
            {
                ExibirFilme(filmePesquisado);
            }
            else
            {
                Console.WriteLine($"Filme '{Nome}' não encontrado.");
            }

        }

        public void PesquisarPorDiretor()
        {
            Console.Write("Nome do diretor a ser pesquisado: ");
            string Nome = Console.ReadLine() ?? "";
            var filmesDoDiretor = filmes.Where(f => f.Diretor.Equals(Nome, StringComparison.OrdinalIgnoreCase)).ToList();
            if (!filmesDoDiretor.Any())
            {
                Console.WriteLine("Nenhum filme encontrado para esse diretor.");
                return;
            }
            else
            {
                Console.WriteLine("Filmes do diretor " + Nome + ":");
                foreach (var filmes in filmesDoDiretor)
                {
                    ExibirFilme(filmes);
                }
            }
        }


        public void ExibirFilme(Filmes filme)
        {
            Console.WriteLine($"Nome: {filme.Nome}, Diretor: {filme.Diretor}, Ano: {filme.Ano}, Estrelas: {filme.Estrelas}");
        }

        public void RanquearFilmes()
        {
            Console.WriteLine("Ranqueando filmes por estrelas: ");
            var filmesRanqueados = filmes.OrderByDescending(f => (int)f.Estrelas).ThenBy(f => f.Nome).ToList();
            foreach (var rank in filmesRanqueados)
            {
                ExibirFilme(rank);
            }
        }

    }
}
