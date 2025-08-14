using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASM1_VuThienTruong.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionToCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Customers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Customers",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "Siêu xe" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { null, "Xe thể thao phổ thông" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                column: "Password",
                value: "123456");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                column: "Password",
                value: "123456");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                column: "Password",
                value: "123456");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Siêu xe mạnh mẽ, tốc độ tối đa 350 km/h", "", "Lamborghini Aventador", 15000000m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { "Thiết kế khí động học, tăng tốc 0-100 km/h trong 2.5s", "", "Ferrari SF90 Stradale", 17000000m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[] { 1, "Mẫu xe huyền thoại của Porsche", "", "Porsche 911 Turbo S", 12000000m, 0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 4, 1, "Tốc độ tối đa 341 km/h", "", "McLaren 720S", 14000000m, 0 },
                    { 5, 1, "Sang trọng và hiệu suất vượt trội", "", "Aston Martin DBS Superleggera", 16000000m, 0 },
                    { 6, 2, "Biểu tượng tốc độ Nhật Bản", "", "Nissan GT-R Nismo", 8000000m, 0 },
                    { 7, 2, "Huyền thoại thể thao Nhật Bản", "", "Toyota Supra GR", 5000000m, 0 },
                    { 8, 2, "Thiết kế động cơ đặt giữa", "", "Chevrolet Corvette C8", 6000000m, 0 },
                    { 9, 2, "Mạnh mẽ và hầm hố", "", "Ford Mustang Shelby GT500", 7000000m, 0 },
                    { 10, 2, "Hiệu suất và sự sang trọng kết hợp", "", "BMW M4 Competition", 6500000m, 0 },
                    { 11, 1, "Tiếng máy V10 đặc trưng", "", "Audi R8 V10 Plus", 11000000m, 0 },
                    { 12, 2, "Phong cách Anh Quốc", "", "Jaguar F-Type SVR", 9000000m, 0 },
                    { 13, 1, "Động cơ V8 mạnh mẽ", "", "Mercedes-AMG GT R", 10500000m, 0 },
                    { 14, 2, "Thiết kế tương lai", "", "Lexus LC 500", 8500000m, 0 },
                    { 15, 2, "Nhỏ gọn và cực nhanh", "", "Alfa Romeo 4C", 4000000m, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Customers",
                newName: "Fullname");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Customers",
                newName: "role");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Fullname",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Carts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Các mẫu điện thoại thông minh", "Điện thoại" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Ốp lưng, sạc, tai nghe", "Phụ kiện" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "role" },
                values: new object[] { "123456", "Admin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "role" },
                values: new object[] { "123456", "Customer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "PasswordHash", "role" },
                values: new object[] { "123456", "Customer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Image", "Name", "Price", "Stock" },
                values: new object[] { "iphone13.jpg", "iPhone 13", 20000m, 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Image", "Name", "Price", "Stock" },
                values: new object[] { "galaxyS21.png", "Samsung Galaxy S21", 18000m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Image", "Name", "Price", "Stock" },
                values: new object[] { 2, "oplung.jpg", "Ốp lưng iPhone", 200m, 150 });
        }
    }
}
