using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProdutosMVC.Models;



//Fernando Avelino da Silva CB3008053

namespace ProdutosMVC.Data
{
    public class ProdutoContext: DbContext
    {
        public DbSet<Produto> Departamentos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=TP03;Integrated Security = true");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }


    }
}
