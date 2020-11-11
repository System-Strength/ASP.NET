using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppBancoDominio
{
    public class Gerente
    {
        [DisplayName("ID do Gerente:")]
        public int id_ger { get; set; }
        [DisplayName("CPF do Gerente:")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Esse campo deve ter 11 caracteres!")]
        public string cpf_ger { get; set; }
        [DisplayName("Nome do Gerente:")]
        public string nm_ger { get; set; }
        [DisplayName("Telefone do Gerente:")]
        public string tel_ger { get; set; }
    }
}
