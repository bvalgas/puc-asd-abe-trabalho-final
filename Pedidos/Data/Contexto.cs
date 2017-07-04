using Microsoft.EntityFrameworkCore;
using Pedidos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedidos.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().HasKey(c => c.id);
            modelBuilder.Entity<Orcamento>().HasKey(c => c.id);
        }
    }
}
