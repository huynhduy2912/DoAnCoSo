using DoAnNhom11.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using DoAnNhom11.Extensions;

namespace DoAnNhom11.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public virtual DbSet<ProductCategory> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductImage> ProducImages { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<ReviewsImage> ReviewsImage { get; set; }
        public DbSet<ShopCategory> ShopCategories { get; set; }
        public DbSet<Payment> Payments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Products
            modelBuilder.Entity<Product>()
            .HasOne(p => p.ProductCategory)
            .WithMany(b => b.Products)
            .HasForeignKey(p => p.ProductCategoryId);
            // Products
            modelBuilder.Entity<Product>()
            .HasOne(p => p.Brand)
            .WithMany(b => b.Products)
            .HasForeignKey(p => p.BrandId);

            // Orders
            modelBuilder.Entity<Order>()
            .HasOne(p => p.ApplicationUser)
            .WithMany(b => b.Oders)
            .HasForeignKey(p => p.UserId);
            modelBuilder.Entity<Order>()
            .HasOne(p => p.OrderStatus)
            .WithMany(b => b.Orders)
            .HasForeignKey(p => p.OrderStatusId);

            // Order_items
            modelBuilder.Entity<OrderDetail>()
            .HasOne(p => p.Order)
            .WithMany(b => b.OrderDetails)
            .HasForeignKey(p => p.OrderId);
            modelBuilder.Entity<OrderDetail>()
            .HasOne(p => p.Product)
            .WithMany(b => b.OrderDetails)
            .HasForeignKey(p => p.ProductId);
           
            
            //DataSeed.Seed(modelBuilder);

        }
        public DbSet<DoAnNhom11.Models.VoucherCategory> VoucherCategory { get; set; } = default!;
    }
}
