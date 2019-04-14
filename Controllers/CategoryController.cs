using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsCategories.Controllers
{
    public class CategoryController : Controller
    {
        private ProdCatContext dbContext;

        public CategoryController(ProdCatContext context)
        {
            dbContext = context;
        }

        [HttpGet("GetCategoriesList")]
        public IActionResult GetCategoriesList()
        {
            List<CategoryModel> Categories = dbContext.Categories.ToList();
            ViewModels model = new ViewModels();
            model.Categories = Categories;

            return View("Categories", model);
        }

        [HttpPost("SaveCategory")]
        public IActionResult SaveCategory(CategoryModel Category)
        {
            if(ModelState.IsValid)
            {
                Category.CreatedAt = DateTime.Now;
                dbContext.Add(Category);
                dbContext.SaveChanges();
                return RedirectToAction("GetCategoriesList");
            }
            else
            {
                List<CategoryModel> Categories = dbContext.Categories.ToList();
                ViewModels model = new ViewModels();
                model.Categories = Categories;

                return View("Categories", model);
            }
        }        

        [HttpGet("GetCategoryDetail/{CatId}")]
        public IActionResult GetCategoryDetail(int CatId)
        {
            CategoryModel category = dbContext.Categories
                .Include(c => c.CatRel)
                .ThenInclude(pr => pr.Products)
                .FirstOrDefault(c => c.CategoryId == CatId);

            // collecting existing categoty list
            List<int> ProdIdList = new List<int>();
            foreach(var ProdCatRel in category.CatRel)
            {
                ProdIdList.Add(ProdCatRel.Products.ProductId);
            }
            
            // filtering the unrelated arrays list
            List<ProductModel> Products = dbContext.Products
                .Where(p => !ProdIdList.ToArray().Contains(p.ProductId))
                .ToList();

            ViewModels model = new ViewModels();
            model.CategoryModel = category;
            model.Products = Products;

            return View("CategoryDetail", model);
        }

        [HttpPost("SaveCategoryProductRel/{CatId}")]
        public IActionResult SaveCategoryProductRel(ViewModels viewModel, int CatId)
        {
            ProductModel prod = dbContext.Products
                .FirstOrDefault(p => p.ProductId == viewModel.ProductModel.ProductId);
            CategoryModel cat = dbContext.Categories
                .FirstOrDefault(c => c.CategoryId == CatId);
            
            ProductCategoryRel ProdCatRel = new ProductCategoryRel();
            ProdCatRel.Products = prod;
            ProdCatRel.Categories = cat;

            dbContext.Add(ProdCatRel);
            dbContext.SaveChanges();

            return RedirectToAction("GetCategoryDetail", new{ CategoryId = CatId});
        }
    }
}