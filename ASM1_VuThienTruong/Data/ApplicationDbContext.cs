using ASM1_VuThienTruong.Models;
using Microsoft.EntityFrameworkCore;

namespace ASM1_VuThienTruong.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Siêu xe", Description = "Các mẫu siêu xe cao cấp, tốc độ và sang trọng hàng đầu thế giới" },
                new Category { CategoryId = 2, Name = "Xe thể thao phổ thông", Description = "Các mẫu xe thể thao hiệu suất cao với giá thành dễ tiếp cận hơn" }
            );

            // Products
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Lamborghini Aventador", Price = 15000000, Stock = 5, Description = "Siêu xe mạnh mẽ, tốc độ tối đa 350 km/h", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 2, Name = "Ferrari SF90 Stradale", Price = 17000000, Stock = 3, Description = "Thiết kế khí động học, tăng tốc 0-100 km/h trong 2.5s", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 3, Name = "Porsche 911 Turbo S", Price = 12000000, Stock = 7, Description = "Mẫu xe huyền thoại của Porsche", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 4, Name = "McLaren 720S", Price = 14000000, Stock = 4, Description = "Tốc độ tối đa 341 km/h", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 5, Name = "Aston Martin DBS Superleggera", Price = 16000000, Stock = 2, Description = "Sang trọng và hiệu suất vượt trội", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 6, Name = "Nissan GT-R Nismo", Price = 8000000, Stock = 8, Description = "Biểu tượng tốc độ Nhật Bản", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 7, Name = "Toyota Supra GR", Price = 5000000, Stock = 10, Description = "Huyền thoại thể thao Nhật Bản", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 8, Name = "Chevrolet Corvette C8", Price = 6000000, Stock = 6, Description = "Thiết kế động cơ đặt giữa", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 9, Name = "Ford Mustang Shelby GT500", Price = 7000000, Stock = 5, Description = "Mạnh mẽ và hầm hố", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 10, Name = "BMW M4 Competition", Price = 6500000, Stock = 7, Description = "Hiệu suất và sự sang trọng kết hợp", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 11, Name = "Audi R8 V10 Plus", Price = 11000000, Stock = 4, Description = "Tiếng máy V10 đặc trưng", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 12, Name = "Jaguar F-Type SVR", Price = 9000000, Stock = 6, Description = "Phong cách Anh Quốc", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 13, Name = "Mercedes-AMG GT R", Price = 10500000, Stock = 3, Description = "Động cơ V8 mạnh mẽ", ImageUrl = "", CategoryId = 1 },
                new Product { ProductId = 14, Name = "Lexus LC 500", Price = 8500000, Stock = 5, Description = "Thiết kế tương lai", ImageUrl = "", CategoryId = 2 },
                new Product { ProductId = 15, Name = "Alfa Romeo 4C", Price = 4000000, Stock = 9, Description = "Nhỏ gọn và cực nhanh", ImageUrl = "", CategoryId = 2 }
            );

            // Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, Username = "admin", Password = "123456", FullName = "Quản trị viên", Email = "admin@example.com" },
                new Customer { CustomerId = 2, Username = "user1", Password = "123456", FullName = "Nguyễn Văn A", Email = "a@example.com" },
                new Customer { CustomerId = 3, Username = "user2", Password = "123456", FullName = "Trần Thị B", Email = "b@example.com" }
            );
        }
    }
}
