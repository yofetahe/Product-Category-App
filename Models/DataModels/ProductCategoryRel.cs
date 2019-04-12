using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProductsCategories.Models
{
    public class ProductCategoryRel
    {
        [Key]
        public int ProdCatId { get; set; }

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public ProductModel Products { get; set; }

        public CategoryModel Categories { get; set; }
    }
}   