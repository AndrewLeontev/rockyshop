using System;
using System.ComponentModel.DataAnnotations;

namespace RockyShop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order for category most be greatger then 0")]
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
    }
}
