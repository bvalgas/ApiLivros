using ApiLivros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLivros.Data
{
    public static class ContextoExtensions
    {
        public static void InitializeData(this Contexto context)
        {
            IncluirLivro(context, "978-3-16-148410-0", "Autor Desconhecido", "Livro Bom", "Editora Nova Esperança", "2010");
            IncluirLivro(context, "234-4-15-148410-1", "Autor Conhecido", "Livro Mais ou Menos", "Editora Já Era Esperança", "2011");
            IncluirLivro(context, "621-3-16-148410-2", "Autor Pouco Conhecido", "Livro Ruim", "Editora Nova Esperança", "2015");
            IncluirLivro(context, "863-6-11-148410-3", "Autor Muito Conhecido", "Livro Humm...", "Editora Nova Esperança", "2017");
            IncluirLivro(context, "222-7-11-148410-4", "Autor Desconhecido", "Livro 123", "Editora Nova Esperança", "2000");
            IncluirLivro(context, "653-8-13-148410-5", "Autor Muito Conhecido", "Livro abc", "Editora Nova Esperança", "2012");
            IncluirLivro(context, "522-2-10-148410-6", "Autor Desconhecido", "Livro qwert", "Editora Nova Esperança", "2013");
            IncluirLivro(context, "342-3-11-148410-7", "Autor Muito Conhecido", "Livro 1313", "Editora Nova Esperança", "2015");
            IncluirLivro(context, "674-3-10-148410-8", "Autor Desconhecido", "Livro ???", "Editora Nova Esperança", "2017");
            IncluirLivro(context, "233-3-16-148410-9", "Autor Conhecido", "Livro Teste", "Editora Nova Esperança", "2015");

            context.SaveChanges();
        }

        private static void IncluirLivro(
            Contexto context,
            string isbn, string autor, string nome, string editora, string ano)
        {
            context.Livros.Add(
                new Livro()
                {
                    ISBN = isbn,
                    Autor = autor,
                    Nome = nome,
                    Editora = editora,
                    AnoPublicacao = ano
                });
        }
    }
}
