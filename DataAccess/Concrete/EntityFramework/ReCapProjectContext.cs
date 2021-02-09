using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje class'larını ilişkilendirerek bağlar.
    public class ReCapProjectContext : DbContext
    {
        //override void tab-tab
        //Bu methot senin projenin hangi veritabani ile ilişkisi olduğunu belirteceğimiz yerdir.  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@=normal ters slash
            optionsBuilder.UseSqlServer(@"Server=MASAÜSTÜ-MUSA/sqlexpress;Database=ReCapProjectDB;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; } //Benim Car nesnemi veritabanımdaki Cars tablom ile bağla.
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}
