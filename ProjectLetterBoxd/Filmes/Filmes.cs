using System;
using System.Collections.Generic;

namespace Filmes
{
    class Filmes
    {
        public string? Nome { get; set; }
        public string? Diretor { get; set; }
        public int Ano { get; set; }
        public Estrelas Estrelas { get; set; }

        public Filmes(string? nome, string? diretor, int ano, Estrelas estrelas)
        {
            Nome = nome;
            Diretor = diretor;
            Ano = ano;
            Estrelas = estrelas;
        }

    }
}
