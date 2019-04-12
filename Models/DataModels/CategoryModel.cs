using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProductsCategories.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            this.CatRel = new List<ProductCategoryRel>();
        }

        [Key]
        public int CategoryId { get; set; }

        [Display(Name="Category Name")]
        [Required(ErrorMessage="Category name is requred")]
        public String name { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<ProductCategoryRel> CatRel { get; set; }
    }
}