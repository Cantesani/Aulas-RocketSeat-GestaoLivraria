namespace GestaoLivraria.Comunication.Requests
{
    public class RequestRegistroLivroJson
    {

        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Genero { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}
