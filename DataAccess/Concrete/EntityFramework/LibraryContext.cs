using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Trusted_Connection=true");
        }

        public DbSet<Islem> islem { get; set; }

        public DbSet<Kitap> kitap { get; set; }

        public DbSet<Ogrenci> ogrenci { get; set; }

        public DbSet<Tur> tur { get; set; }

        public DbSet<Yazar> yazar { get; set; }
    }
}
