using System;
using System.Runtime.Intrinsics.X86;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace DataAccess.Concrete.EntityFramework
{
	public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Northwind;User Id=sa;Password=reallyStrongPwd123;TrustServerCertificate=True; Encrypt=false");

            //Server=localhost,1433;Database=northwind;User Id=sa;Password=12345;


        }
        public DbSet<Product> products { get; set; }

        public DbSet<Category> categories { get; set; }

        public DbSet<Customer> customers { get; set; }
    }
}

