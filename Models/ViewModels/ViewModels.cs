using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProductsCategories.Models
{
    public class ViewModels
    {
        public ProductModel ProductModel { get; set; }
        public List<ProductModel> Products { get; set; }
        public CategoryModel CategoryModel { get; set; }
        public List<CategoryModel> Categories { get; set; }
        public ProductCategoryRel ProductCategoryRel { get; set; }

    }
}