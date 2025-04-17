using GestaoLivraria.Comunication.Requests;
using GestaoLivraria.ItensLivraria;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoLivraria.Controllers
{
    public class ControleLivrosController : GestaoLivrariaBaseController
    {
        [HttpPost]
        [ProducesResponseType(typeof(RequestRegistroLivroJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegistroLivroJson response)
        {
            var novoLivro = new Livro()
            {
                Titulo = response.Titulo,
                Autor = response.Autor,
                Genero = response.Genero,
                Preco = response.Preco,
                QuantidadeEstoque = response.QuantidadeEstoque
            };

            return Created(string.Empty, novoLivro);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Livro>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            var todosLivros = new List<Livro>()
            {
                new Livro {Id = 1, Titulo = "Livro1", Autor = "Gabriel", Genero = "Romance", Preco = 10, QuantidadeEstoque = 100},
                new Livro {Id = 2, Titulo = "Livro2", Autor = "May", Genero = "Terror", Preco = 20, QuantidadeEstoque = 200},
                new Livro {Id = 3, Titulo = "Livro3", Autor = "Sah", Genero = "Comedia", Preco = 30, QuantidadeEstoque = 300},
                new Livro {Id = 4, Titulo = "Livro4", Autor = "Luh", Genero = "Suspense", Preco = 40, QuantidadeEstoque = 400},
            };
            return Ok(todosLivros);
        }

        [HttpGet]
        [Route("{Id}")]
        [ProducesResponseType(typeof(Livro), StatusCodes.Status200OK)]
        public IActionResult GetById([FromRoute] int Id)
        {
            var livro = new Livro()
            {
                Id = 1,
                Titulo = "Livro1",
                Autor = "Gabriel",
                Genero = "Romance",
                Preco = 10,
                QuantidadeEstoque = 100
            };

            return Ok(livro);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] Livro livro)
        {
            return NoContent();
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete([FromBody] Livro livro)
        {

            return NoContent();
        }



    }
}
