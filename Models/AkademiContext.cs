using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efcodefirst.Models
{
    public class AkademiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MELISA\SQLEXPRESS;Database=Akademi;Trusted_Connection=true;TrustServerCertificate=True");
        }
        public DbSet<Category> Categories { get; set; }   
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> suppliers { get; set; }
    }
}
