﻿namespace TesteWeb.Models
{
    public class Contato
    {
        public int Id { get; set; } 

        public string? Nome { get; set; } 

        public string? Email { get; set; } 

        public string? Telefone { get; set; } 

        public string? Endereco { get; set; } 

        public string? Cidade { get; set; } 

        public string? Estado { get; set; } 

        public string? CEP { get; set; } 
        public DateTime DataCadastro { get; set; } 

    }

}
