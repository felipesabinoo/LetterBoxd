using System;
using System.Collections.Generic;

namespace Filmes
{
    class Filmes
    {
        public string? Nome { get; set; }
        public string? Diretor { get; set; }
        public int Ano { get; set; }
        public Enum Estrelas { get; set; }

        public List<Filmes> filmes = new List<Filmes>();

        public Filmes(string? nome, string? diretor, int ano, Enum estrelas)
        {
            Nome = nome;
            Diretor = diretor;
            Ano = ano;
            Estrelas = estrelas;
        }

    }
}
