using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASM1_VuThienTruong.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; } 

        public string? Description { get; set; }
    }
}



