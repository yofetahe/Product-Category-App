using System;
using Microsoft.EntityFrameworkCore;

namespace ProductsCategories.Models
{
    public class ProdCatContext: DbContext
    {
        public ProdCatContext(DbContextOptions options) : base(options){}

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<ProductCategoryRel> ProductCategoryRel { get; set; }
    }
}