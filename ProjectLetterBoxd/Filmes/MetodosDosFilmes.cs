using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


namespace Filmes
{
    internal class MetodosDosFilmes
    {

        private const string CaminhoArquivo = "filmes.csv";

        public List<Filmes> filmes = new List<Filmes>();

        public MetodosDosFilmes()
        {
            CarregarFilmes();
        }

        private void SalvarFilmes()
        {
            var linhas = filmes.Select(f => $"{f.Nome}; {f.Diretor}; {f.Ano}; {(int)f.Estrelas}");
            File.WriteAllLines(CaminhoArquivo, linhas);
        }

        private void CarregarFilmes()
        {
            if (!File.Exists(CaminhoArquivo)) return;
            
            foreach(var linha in File.ReadAllLines(CaminhoArquivo))
            {
                var partes = linha.Split("; ");
                if (partes.Length != 4) continue;

                if (!int.TryParse(partes[2], out int ano)) continue;
                if (!int.TryParse(partes[3], out int estrelasInt)) continue;

                filmes.Add(new Filmes(partes[0], partes[1], ano, (Estrelas)estrelasInt));
            }
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
            SalvarFilmes();
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
            SalvarFilmes();
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

        public void PesquisarPorAno()
        {
            Console.Write("Ano do filme a ser pesquisado: ");
            if(!int.TryParse(Console.ReadLine(), out int Ano))
            {
                Console.WriteLine("Ano inválido.");
                return;
            }
            var filmesDoAno = filmes.Where(f => f.Ano == Ano).ToList();
            if(!filmesDoAno.Any())
            {
                Console.WriteLine("Nenhum filme encontrado para esse ano.");
                return;
            }else
            {
                Console.WriteLine("Filmes do ano " + Ano + ":");
                foreach(var filmes in filmesDoAno)
                {
                    ExibirFilme(filmes);
                }
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
