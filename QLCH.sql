CREATE DATABASE QLCH;
GO

USE QLCH;
GO

-- ✅ 1. Tạo bảng Categories trước
CREATE TABLE Categories (
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Description NVARCHAR(255)
);

-- ✅ 2. Sau đó mới tạo bảng Products (tham chiếu CategoryId)
CREATE TABLE Products (
    ProductId INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(150) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    Stock INT NOT NULL,
    CategoryId INT NOT NULL,
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
);

-- Các bảng còn lại giữ nguyên:
-- Customers
CREATE TABLE Customers (
    CustomerId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100),
    Email NVARCHAR(100) UNIQUE,
    Role NVARCHAR(20) NOT NULL DEFAULT 'Customer'
);

-- Carts
CREATE TABLE Carts (
    CartId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
);

-- CartDetails
CREATE TABLE CartDetails (
    CartDetailId INT IDENTITY(1,1) PRIMARY KEY,
    CartId INT NOT NULL,
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    FOREIGN KEY (CartId) REFERENCES Carts(CartId),
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
);

