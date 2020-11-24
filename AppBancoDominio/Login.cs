using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppBancoDominio
{
    public class Login
    {
        [DisplayName("ID do Funcionário:")]
        [Required(ErrorMessage = "Obrigatório digitar o ID do Funcionário!")]
        [ForeignKey("id_func")]
        public int id_func { get; set; }
        [DisplayName("CPF de Funcionário:")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Esse campo deve ter 11 caracteres!")]
        public string cpf_func { get; set; }
    }
}
