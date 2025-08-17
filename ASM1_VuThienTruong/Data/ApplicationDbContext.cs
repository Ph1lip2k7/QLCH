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
                new Product { ProductId = 1, Name = "Siêu xe mạnh mẽ", Price = 1000000, Stock = 5, Description = "Tốc độ tối đa 350 km/h", ImageUrl = "aventador.jpg", CategoryId = 1 },
                new Product { ProductId = 2, Name = "Porsche 911 Turbo S", Price = 1200000, Stock = 3, Description = "Thiết kế khí động học, tăng tốc 0-100 km/h trong 2.5s", ImageUrl = "~/images/porsche911.jpg", CategoryId = 1 },
                new Product { ProductId = 3, Name = "Aston Martin DBS", Price = 1500000, Stock = 2, Description = "Sang trọng và hiệu suất vượt trội", ImageUrl = "~/images/astonmartin.jpg", CategoryId = 1 },
                new Product { ProductId = 4, Name = "Nissan GT-R", Price = 900000, Stock = 4, Description = "Biểu tượng tốc độ Nhật Bản", ImageUrl = "~/images/nissangtr.jpg", CategoryId = 2 },
                new Product { ProductId = 5, Name = "Toyota Supra GR", Price = 700000, Stock = 6, Description = "Huyền thoại thể thao Nhật Bản", ImageUrl = "~/images/toyotasupra.jpg", CategoryId = 2 },
                new Product { ProductId = 6, Name = "BMW M4 Competition", Price = 800000, Stock = 5, Description = "Hiệu suất và sang trọng kết hợp", ImageUrl = "~/images/bmwm4.jpg", CategoryId = 3 },
                new Product { ProductId = 7, Name = "Audi R8 Plus", Price = 1400000, Stock = 2, Description = "Tiếng máy V10 đặc trưng", ImageUrl = "~/images/audir8.jpg", CategoryId = 1 },
                new Product { ProductId = 8, Name = "Jaguar F-Type", Price = 850000, Stock = 3, Description = "Phong cách Anh Quốc", ImageUrl = "~/images/jaguarftype.jpg", CategoryId = 2 },
                new Product { ProductId = 9, Name = "Mercedes-AMG GT", Price = 1100000, Stock = 4, Description = "Thiết kế tương lai", ImageUrl = "~/images/mercedesamg.jpg", CategoryId = 3 },
                new Product { ProductId = 10, Name = "Alfa Romeo 4C", Price = 650000, Stock = 5, Description = "Nhỏ gọn và cực nhanh", ImageUrl = "~/images/alfaromeo4c.jpg", CategoryId = 2 }
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
