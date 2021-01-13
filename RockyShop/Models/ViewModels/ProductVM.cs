using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RockyShop.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> ReviewSelectList { get; set; }
    }
}
