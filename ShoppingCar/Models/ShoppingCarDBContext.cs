using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ShoppingCar.Models
{
    public partial class ShoppingCarDBContext : DbContext
    {
        public ShoppingCarDBContext()
            : base("name=ShoppingCarDB")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<tMember> tMember { get; set; }
        public virtual DbSet<tOrder> tOrder { get; set; }
        public virtual DbSet<tOrderDetail> tOrderDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.PId)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<tMember>()
                .Property(e => e.Userid)
                .IsUnicode(false);

            modelBuilder.Entity<tMember>()
                .Property(e => e.Pwd)
                .IsUnicode(false);

            modelBuilder.Entity<tMember>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tMember>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tOrder>()
                .Property(e => e.OrderGuid)
                .IsUnicode(false);

            modelBuilder.Entity<tOrder>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<tOrder>()
                .Property(e => e.Receiver)
                .IsUnicode(false);

            modelBuilder.Entity<tOrder>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tOrder>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<tOrderDetail>()
                .Property(e => e.OrderGuid)
                .IsUnicode(false);

            modelBuilder.Entity<tOrderDetail>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<tOrderDetail>()
                .Property(e => e.Pid)
                .IsUnicode(false);

            modelBuilder.Entity<tOrderDetail>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tOrderDetail>()
                .Property(e => e.flsQpproved)
                .IsUnicode(false);
        }
    }
}
