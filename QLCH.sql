CREATE DATABASE ql_xe_the_thao;
GO

USE ql_xe_the_thao;
GO


-- ✅ 1. Tạo bảng Categories trước
CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL
);

GO
-- ✅ 2. Sau đó mới tạo bảng Products (tham chiếu CategoryId)
CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(200) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Description NVARCHAR(MAX),
    ImageUrl NVARCHAR(500),
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

GO
-- Các bảng còn lại giữ nguyên:
-- Customers
CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100)
);

GO
-- Carts
CREATE TABLE Carts (
    CartId INT PRIMARY KEY IDENTITY(1,1),
    CustomerId INT,
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

GO
-- CartDetails
CREATE TABLE Cart_Detail (
    CartDetailId INT PRIMARY KEY IDENTITY(1,1),
    CartId INT,
    ProductId INT,
    Quantity INT,
    FOREIGN KEY (CartId) REFERENCES Carts(CartId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);


-- Thêm cột nếu chưa tồn tại
IF COL_LENGTH('Products', 'Stock') IS NULL
    ALTER TABLE Products ADD Stock INT NULL;

IF COL_LENGTH('Products', 'ImageUrl') IS NULL
    ALTER TABLE Products ADD ImageUrl NVARCHAR(500) NULL;

IF COL_LENGTH('Products', 'Description') IS NULL
    ALTER TABLE Products ADD Description NVARCHAR(MAX) NULL;

-- Nếu CategoryId chưa có thì thêm
IF COL_LENGTH('Products', 'CategoryId') IS NULL
    ALTER TABLE Products ADD CategoryId INT NULL;

    ALTER TABLE Products
ALTER COLUMN ImageUrl NVARCHAR(MAX) NULL;
