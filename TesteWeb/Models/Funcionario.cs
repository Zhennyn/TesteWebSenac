using System.ComponentModel.DataAnnotations.Schema;
using TesteWeb.Enumerador;
namespace TesteWeb.Models
{
    [Table("Funcionario")]
    public class Funcionario
    {
        public int Id { get; set; }

        public string? Login { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAtualização { get; set; }
        public EnumADM Perfil { get; set; }
    }
}
