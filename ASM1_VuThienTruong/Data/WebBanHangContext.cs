using ASM1_VuThienTruong.Models;
using Microsoft.EntityFrameworkCore;


namespace ASM1_VuThienTruong.Data
{
    public class WebBanHangContext : DbContext
    {
        public WebBanHangContext(DbContextOptions<WebBanHangContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Điện thoại", Description = "Các mẫu điện thoại thông minh" },
                new Category { CategoryId = 2, Name = "Phụ kiện", Description = "Ốp lưng, sạc, tai nghe" }
            );

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "iPhone 13", Price = 20000, Stock = 50, CategoryId = 1 },
                new Product { ProductId = 2, Name = "Samsung Galaxy S21", Price = 18000, Stock = 40, CategoryId = 1 },
                new Product { ProductId = 3, Name = "Ốp lưng iPhone", Price = 200, Stock = 150, CategoryId = 2 }
            );

            // Seed Customers
            modelBuilder.Entity<Customers>().HasData(
                new Customers { CustomerId = 1, Username = "admin", PasswordHash = "123456", Fullname = "Quản trị viên", Email = "admin@example.com", role = "Admin" },
                new Customers { CustomerId = 2, Username = "user1", PasswordHash = "123456", Fullname = "Nguyễn Văn A", Email = "a@example.com", role = "Customer" },
                new Customers { CustomerId = 3, Username = "user2", PasswordHash = "123456", Fullname = "Trần Thị B", Email = "b@example.com", role = "Customer" }
            );

        }

    }
}
