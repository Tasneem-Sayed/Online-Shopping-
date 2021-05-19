using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopFashion.Models
{
    public class CategoryDetail
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Category Name Required")]
        public string CategoryName { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
    public class ProductDetail
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Product Name is Required")]
        public string ProductName { get; set; }
        [Required]
        [Range(1,50)]
        public int? CategoryId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [Required(ErrorMessage ="Description is required")]
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public bool? IsFeatured { get; set; }
        [Required]
        [Range(typeof (int),"1","500",ErrorMessage ="Invalid quantity ")]
        public int? Quantity { get; set; }
        [Required]
        [Range(typeof(int), "1", "200000", ErrorMessage = "Invalid price ")]
        public decimal? Price { get; set; }
        public SelectList Categories { get; set; } 
    }
}
