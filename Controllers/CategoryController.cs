using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductsCategories.Models;

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
    }
}