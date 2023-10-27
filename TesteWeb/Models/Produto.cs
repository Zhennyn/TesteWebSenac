﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TesteWeb.Models
{
    [Table("Estoque")]
    public class Estoque
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Autor")]
        [Display(Name = "Autor")]
        public string? Autor { get; set; }

        [Column("Genero")]
        [Display(Name = "Gênero")]
        public string? Genero { get; set; }

        [Column("Preco")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Column("Quantidade")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

    
    }
}