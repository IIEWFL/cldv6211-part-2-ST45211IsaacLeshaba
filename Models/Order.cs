using KhumaloCraft.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhumaloCraft.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        [ForeignKey("User")]
        public string? UserID { get; set; }

        [Required]
        public string? Status { get; set; }

        public string? OrderNumber { get; set; }

        public DateTime? OrderDate { get; set; }

        [Required]
        public decimal Total { get; set; }

        // Navigation property for related User
        public virtual ApplicationUser? User { get; set; }

        // Navigation property for related OrderDetails
        //public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}


