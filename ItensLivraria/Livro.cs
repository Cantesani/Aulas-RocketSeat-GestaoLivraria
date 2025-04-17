namespace GestaoLivraria.ItensLivraria
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }

    }
}
