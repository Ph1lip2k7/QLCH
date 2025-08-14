using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace ASM1_VuThienTruong.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<CartDetail> CartDetails { get; set; }
    }
}


