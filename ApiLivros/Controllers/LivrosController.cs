using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiLivros.Data;
using ApiLivros.Models;

namespace ApiLivros.Controllers
{
    [Route("api/[controller]")]
    public class LivrosController : Controller
    {
        private Contexto _context;

        public LivrosController(Contexto context)
        {
            _context = context;
        }

        // GET api/livros
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_context.Livros.ToList());
        }

        // GET api/livros/isbn
        [HttpGet("{isbn}")]
        public JsonResult Get(string isbn)
        {
            return new JsonResult(_context.Livros.SingleOrDefault(x => x.ISBN == isbn));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Livro livro)
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        // DELETE api/livros/isbn
        [HttpDelete("{isbn}")]
        public void Delete(string isbn)
        {
            var livro = _context.Livros.SingleOrDefault(x => x.ISBN == isbn);
            if (livro != null)
            {
                _context.Livros.Remove(livro);
                _context.SaveChanges();
            }
        }
    }
}
