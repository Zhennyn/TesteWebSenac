﻿using Microsoft.EntityFrameworkCore;

namespace TesteWeb.Models
{

    public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {

    }

    public DbSet<Estoque> Estoque { get; set; }
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<Contato> Contato { get; set;}
    }
}
