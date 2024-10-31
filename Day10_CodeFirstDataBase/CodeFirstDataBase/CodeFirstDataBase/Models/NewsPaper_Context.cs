using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDataBase.Models
{
    public class NewsPaper_Context : DbContext
    {
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Catalog> Catalogs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }

       



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=MOHAMED_SALAH\\SQLEXPRESS;Database=EF_NewsPaper;Trusted_Connection=True;TrustServerCertificate=True;");


        }


        //    // if i want a compsite key
        //    protected override void OnModelCreating(ModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Entity<studentsubject>().HasKey("stid", "subid");
        //    }
    }
}
