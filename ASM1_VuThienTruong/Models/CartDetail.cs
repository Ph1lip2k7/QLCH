using System.ComponentModel.DataAnnotations;

namespace ASM1_VuThienTruong.Models
{
    public class CartDetail
    {
        public int CartDetailId { get; set; }

        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
    }
}


