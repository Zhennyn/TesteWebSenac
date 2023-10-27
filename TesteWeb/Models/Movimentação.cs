using TesteWeb.Enumerador;

namespace TesteWeb.Models
{
    public class Movimentação
    {
        public int Id { get; set; } 
        public decimal Saldo { get; set; }
        public string? Relatório { get; set; }
        public DateTime? DataMovimentação { get; set; }
        public TipoMovimentação Status { get; set; }

        public Estoque? ProdutoAfetado { get; set; }
    }
}
