using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteWeb.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Required(ErrorMessage = "O campo ID é obrigatório.")]
        [Display(Name = "ID")]
        public string Id { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }
    }
}
