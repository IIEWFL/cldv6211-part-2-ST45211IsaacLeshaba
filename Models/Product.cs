using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhumaloCraft.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(250)]
        public string? ProdName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public double Price { get; set; }

        [Required]
        public int CatID    { get; set; }

        [ForeignKey("CatID")]
        public Category? Category { get; set; }

        [StringLength(250)]
        public string? ImageUrl { get; set; }

        [Required]
        public bool ProdAvailability { get; set; }

        public string? PostedBy { get; set; }

        public string? PostedByRole { get; set; }

        public int Stock { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
    }
}
