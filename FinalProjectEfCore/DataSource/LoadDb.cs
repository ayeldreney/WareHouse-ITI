using FinalProjectEfCore.config;
using FinalProjectEfCore.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectEfCore.DataSource
{
    public class LoadDb:DbContext
    {

    public DbSet<Login> login { get; set; }   
    public DbSet<Company> Company { get; set; }
     public DbSet<Product> Product { get; set; }
        public DbSet<WareHouse> wareHouses { get; set; }    
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyPermission> supplyPermissions { get; set; }  

        public DbSet<DismissalNotice> dismissalNotices { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)=>
            optionsBuilder.UseSqlServer("Server=.;Database=FinalProjectEF;Trusted_Connection=True;");



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>();
            modelBuilder.Entity<ProductUnit>().HasKey(x => new { x.Product_Id, x.UnitOfMesurement_Id });
            modelBuilder.Entity<ProductUnit>().HasOne(x => x.Product).WithMany(x => x.productUnits).HasForeignKey(p => p.Product_Id).OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<ProductUnit>().HasOne(x => x.UnitOfMesurement).WithMany(x => x.productUnits).HasForeignKey(p => p.UnitOfMesurement_Id).OnDelete(DeleteBehavior.ClientSetNull);





            base.OnModelCreating(modelBuilder);
        }



    }
}
