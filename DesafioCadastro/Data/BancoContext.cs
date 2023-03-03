using System;
using DesafioCadastro.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioCadastro.Data
{
	public class BancoContext : DbContext
	{
		public BancoContext(DbContextOptions<BancoContext>options) : base(options)
		{
		}

		public DbSet<ContatoModel> Cadastro { get; set; }
	}
}

