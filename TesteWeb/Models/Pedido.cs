namespace TesteWeb.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public decimal Quantidade { get; set; }
        public string? Destinatario { get; set; }
        public DateTime Horariodopedido { get; set; }
        public DateTime? Horariodeatualização { get; set; }
    }
}
