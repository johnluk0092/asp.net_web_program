using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebsiteBanHang.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }

        // Navigation Property
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
