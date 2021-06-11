using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Configurations
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) 
        { 
        }

        //Pro Entity saber que é pra usar no banco
        public DbSet<Product> Products { get; set; }

        //Configuração pra poder usar a Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionStringConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetConnectionStringConfig()
        {
            string conn = "Server=LAURA\\SQLEXPRESS;Database=ECommerce;Trusted_Connection=True;MultipleActiveResultSets=true";
            return conn;
        }
    }
}
