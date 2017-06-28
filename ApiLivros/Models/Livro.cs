using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivros.Models
{
    public class Livro
    {
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public string Nome { get; set; }
        public string Editora { get; set; }
        public string AnoPublicacao { get; set; }

    }
}
