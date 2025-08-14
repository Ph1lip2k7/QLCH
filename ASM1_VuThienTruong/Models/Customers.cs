using System.ComponentModel.DataAnnotations;
namespace ASM1_VuThienTruong.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}

