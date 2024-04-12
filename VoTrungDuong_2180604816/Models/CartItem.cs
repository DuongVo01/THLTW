using System.ComponentModel.DataAnnotations;

namespace VoTrungDuong_2180604816.Models
{
    public class CartItem
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
