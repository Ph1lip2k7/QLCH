using System.ComponentModel.DataAnnotations;
namespace ASM1_VuThienTruong.Models
{
    public class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public string role { get; set; } = "Customer"; // Default role is Customer
        public ICollection<Cart> Carts { get; set; }
    }
}
