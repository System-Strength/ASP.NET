﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppBancoDominio
{
    public class Funcionario
    {
        [DisplayName("ID do Funcionário:")]
        public int id_func { get; set; }
        [DisplayName("CPF do Funcionário:")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "Esse campo deve ter 11 caracteres!")]
        public string cpf_func { get; set; }
        [DisplayName("Nome do Funcionário:")]
        public string nm_func { get; set; }
        [DisplayName("Cargo do Funcionário:")]
        public string cg_func { get; set; }
        [DisplayName("Endereço do Funcionário:")]
        public string end_func { get; set; }
        [DisplayName("Telefone do Funcionário:")]
        public string tel_func { get; set; }
        [DisplayName("sexo do Funcionário:")]
        public string sx_func { get; set; }
    }
}

