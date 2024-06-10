using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft.Models
{
    public class Category
    {
        [Key]
        public int CatID { get; set; }

        [Required]
        [StringLength(250)]
        public  string? CatName { get; set; }

        public ICollection<Product> ?Products { get; set; }
    }
}
