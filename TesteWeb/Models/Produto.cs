using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TesteWeb.Models
{
    [Table("Estoque")]
    public class Estoque
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Autor { get; set; }
        public string? Genero { get; set; }
        public decimal Preco { get; set; }
        public decimal  Quantidade { get; set; }
    }
}