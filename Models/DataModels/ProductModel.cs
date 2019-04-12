using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProductsCategories.Models
{
    public class ProductModel
    {
        public ProductModel(){
            this.ProdRel = new List<ProductCategoryRel>(); 
        }
        
       [Key]
       public int ProductId { get; set; }

       [Display(Name="Product Name")]
       [Required(ErrorMessage="Product name is required.")]       
       public string Name { get; set; }

       [Display(Name="Description")]
       [Required(ErrorMessage="Description is required.")]
       public string description { get; set; }

       [Display(Name="Price")]       
       [Range(0.01, double.MaxValue, ErrorMessage="Price must be greater than 0.")]
       public double price { get; set; }

       public DateTime CreatedAt { get; set; } = DateTime.Now;

       public DateTime UpdatedAt { get; set; } = DateTime.Now;

       public List<ProductCategoryRel> ProdRel { get; set; } = new List<ProductCategoryRel>(); 
    }
}