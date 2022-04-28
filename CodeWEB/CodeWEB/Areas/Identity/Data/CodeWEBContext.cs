using CodeWEB.Areas.Identity.Data;
using CodeWEB.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeWEB.Areas.Identity.Data;

public class CodeWEBContext : IdentityDbContext<CodeWEBUser>
{
    public CodeWEBContext(DbContextOptions<CodeWEBContext> options)
        : base(options)
    {
    }
    public DbSet<Store> Store { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderDetail> OrderDetail { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        base.OnModelCreating(builder);
        builder.Entity<CodeWEBUser>()
            .HasOne<Store>(au => au.Store)
            .WithOne(st => st.User)
            .HasForeignKey<Store>(st => st.UId);

        builder.Entity<Book>()
            .HasOne<Store>(b => b.Store)
            .WithMany(st => st.Books)
            .HasForeignKey(b => b.StoreId);

        builder.Entity<Order>()
            .HasOne<CodeWEBUser>(o => o.User)
            .WithMany(ap => ap.Orders)
            .HasForeignKey(o => o.UId);

        builder.Entity<OrderDetail>()
            .HasKey(od => new { od.OrderId, od.BookIsbn });
        builder.Entity<OrderDetail>()
            .HasOne<Order>(od => od.Order)
            .WithMany(or => or.OrderDetails)
            .HasForeignKey(od => od.OrderId);
        builder.Entity<OrderDetail>()
            .HasOne<Book>(od => od.Book)
            .WithMany(b => b.OrderDetails)
            .HasForeignKey(od => od.BookIsbn);

    }
}
