using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        [Required]
        public int OrderID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal SubTotal { get; set; }

        // Navigation property for related Order
        public virtual Order? Order { get; set; }

        // Navigation property for related Product
        public virtual Product? Product { get; set; }
    }

}
