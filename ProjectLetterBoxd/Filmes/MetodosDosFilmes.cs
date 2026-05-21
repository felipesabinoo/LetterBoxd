using System;
using System.Collections.Generic;


namespace Filmes
{
    internal class MetodosDosFilmes
    {

        public List<Filmes> filmes = new List<Filmes>();

        public MetodosDosFilmes()
        {
        }

        public void AdicionarFilme(string? nome, string? diretor, int ano, Enum estrelas)
        {
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

        public void RemoverFilme(string nome)
        {
            var filmeARemover = filmes.Find(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (filmeARemover != null)
            {
                filmes.Remove(filmeARemover);
                Console.WriteLine($"Filme '{filmeARemover.Nome}' removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Filme '{nome}' não encontrado.");
            }

        }

        public void PesquisarPorFilme(string nome)
        {
            var filmePesquisado = filmes.Find(f => f.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (filmePesquisado != null)
            {
                ExibirFilme(filmePesquisado);
            }
            else
            {
                Console.WriteLine($"Filme '{nome}' não encontrado.");
            }

        }

        public void ExibirFilme(Filmes filme)
        {
            Console.WriteLine($"Nome: {filme.Nome}, Diretor: {filme.Diretor}, Ano: {filme.Ano}, Estrelas: {filme.Estrelas}");
        }

    }
}
