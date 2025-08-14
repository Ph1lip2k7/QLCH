using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ASM1_VuThienTruong.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public int CustomerId { get; set; }
        public Customers Customer { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        // Quan hệ 1-n: 1 Cart có nhiều CartDetail
        public ICollection<CartDetail> CartDetails { get; set; }
    }
}
