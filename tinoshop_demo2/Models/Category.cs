using System.ComponentModel.DataAnnotations;

namespace tinoshop_demo2.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }

        [Required]
        [StringLength(500)]
        public string? CategoryDescription { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
