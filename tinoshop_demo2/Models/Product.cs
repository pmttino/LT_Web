using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tinoshop_demo2.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public decimal ProductPrice { get; set; }

        public string? ProductDescription { get; set; }
        [Required]
        public int ProductQuantity { get; set; }

        public string? ProductImage { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }

        
    }
}
