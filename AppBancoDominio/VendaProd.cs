﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBancoDLL
{
    public class VendaProd
    {
        public int cd_venda { get; set; }
        [DisplayName("Nome do Cliente:")]
        public string Nm_cli { get; set; }
        [DisplayName("CPF do Cliente:")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Esse campo deve ter 11 caracteres!")]
        public string Cpf_cli { get; set; }
        [DisplayName("Endereço do Cliente:")]
        public string End_cli { get; set; }
        [DisplayName("Complemento do Cliente:")]
        public string Comple_cli { get; set; }
        [DisplayName("Telefone do Cliente:")]
        public string Tel_cli { get; set; }
        [DisplayName("Nome do Produto:")]
        [Required(ErrorMessage = "Obrigatótio digitar o nome do produto!")]
        public string Nm_prod { get; set; }
        [DisplayName("Quantidade do Produto:")]
        public int Qntd_prod { get; set; }
        [DisplayName("Categoria do Produto:")]
        public string Cat_prod { get; set; }
        [DisplayName("Forma de pagamento:")]
        public string Forma_paga { get; set; }
    }
}