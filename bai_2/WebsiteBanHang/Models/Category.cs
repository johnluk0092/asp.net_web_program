using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace WebsiteBanHang.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Product> Products { get; set; }
    }
}
