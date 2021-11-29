using Microsoft.AspNetCore.Mvc;
using NetCoreMVCApp.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCApp.Controllers
{
    public class ProductController : Controller
    {
        // CodeMaid
        public IActionResult Index()
        {
            var products = new List<ProductListVM>() { 
                new ProductListVM
            {
                Name = "A",
                Price = 10,
                Stock = 20
            },
                new ProductListVM{
                    Name = "B",
                    Price = 20,
                    Stock = 100
                }

            };

            return View(products);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var products = new List<ProductCreateIM>();
            products.Add(default(ProductCreateIM));
            products.Add(default(ProductCreateIM));


            return View(products);
        }

        [HttpPost]
        public IActionResult Create(ProductCreateIM model)
        {
            // Validayon kontrolü için ModelState
            if (ModelState.IsValid)
            {
                // Db ye gönderme
            }

            return View();
        }
    }
}
