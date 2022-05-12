
using System;

namespace demo.DAL
{
    using Microsoft.EntityFrameworkCore;
    using demo.Models;
    public class MyContext:DbContext
    {
        public MyContext() { }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        //添加实体模型
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductType> ProductType { get; set; }

        //实体模型创建时
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>(e =>
            {
                e.HasKey(p=> p.PTID);
                e.Property(p=> p.PTName)
                 .IsRequired();
            });

            modelBuilder.Entity<Products>(e =>
            {
                e.HasKey(p => p.ProID);
                e.Property(p => p.ProName)
                 .IsRequired()
                 .HasMaxLength(20).IsUnicode(true);
                e.Property(p => p.ProPrice)
                 .IsRequired();
                e.HasOne(p => p.ProductType)
                 .WithMany(e=> e.Products)
                 .HasForeignKey(e=>e.PTID)
                 .OnDelete(DeleteBehavior.Cascade)
                 .HasConstraintName("FK_Products_ProductType");
            });
        }
    }
}
