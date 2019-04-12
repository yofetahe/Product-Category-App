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
    public class ProductController : Controller
    {

        private ProdCatContext dbContext;

        public ProductController(ProdCatContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<ProductModel> products = dbContext.Products.ToList();
            ViewModels model = new ViewModels();
            model.Products = products;

            return View(model);
        }

        [HttpPost("SaveProduct")]
        public IActionResult SaveProduct(ProductModel Product)
        {
            if(ModelState.IsValid)
            {
                Product.CreatedAt = DateTime.Now;
                dbContext.Add(Product);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                List<ProductModel> products = dbContext.Products.ToList();
                ViewModels model = new ViewModels();
                model.Products = products;

                return View("Index", model);
            }
        }



        [HttpGet("GetProductDetail/{ProdId}")]
        public IActionResult GetProductDetail(int ProdId)
        {
            ProductModel product = dbContext.Products
                .Include(rel => rel.ProdRel)
                .ThenInclude(pr => pr.Categories)
                .FirstOrDefault(p => p.ProductId == ProdId);

            // collecting existing categoty list
            List<int> CatIdList = new List<int>();
            foreach(var ProdCatRel in product.ProdRel)
            {
                CatIdList.Add(ProdCatRel.Categories.CategoryId);
            }
            
            // filtering the unrelated arrays list
            List<CategoryModel> Categories = dbContext.Categories
                .Where(c => !CatIdList.ToArray().Contains(c.CategoryId))
                .ToList();

            ViewModels model = new ViewModels();
            model.ProductModel = product;
            model.Categories = Categories;

            return View("ProductDetail", model);
        }

        [HttpPost("SaveProductCategoryRel/{ProdId}")]
        public IActionResult SaveProductCategoryRel(ViewModels viewModel, int ProdId)
        {
            
            ProductModel prod = dbContext.Products
                .FirstOrDefault(p => p.ProductId == ProdId);
            CategoryModel cat = dbContext.Categories
                .FirstOrDefault(c => c.CategoryId == viewModel.CategoryModel.CategoryId);
            
            ProductCategoryRel ProdCatRel = new ProductCategoryRel();
            ProdCatRel.Products = prod;
            ProdCatRel.Categories = cat;

            dbContext.Add(ProdCatRel);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
