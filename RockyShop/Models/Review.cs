using System;
using System.ComponentModel.DataAnnotations;

namespace RockyShop.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [MinLength(3)]
        public string UserName { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
