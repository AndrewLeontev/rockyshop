using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RockyShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Required]
        [MinLength(15)]
        public string Description { get; set; }


        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        public string ShortDesc { get; set; }

        [Range(1, double.MaxValue)]
        public double Price { get; set; }

        public string Image { get; set; }

        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [Display(Name = "Review")]
        public int ReviewId { get; set; }
        [ForeignKey("ReviewId")]
        public virtual Review Review { get; set; }
    }
}
