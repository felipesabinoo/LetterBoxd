using System;
using System.Collections.Generic;
using Filmes;


namespace Filmes
{
    class ExceptionFilmes : System.Exception
    {
        public ExceptionFilmes() { }
        public ExceptionFilmes(string message) : base(message) { }
        public ExceptionFilmes(string message, Exception inner) : base(message, inner) { }
    }
}
