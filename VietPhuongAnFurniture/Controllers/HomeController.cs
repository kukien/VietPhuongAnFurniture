using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;
using VietPhuongAnFurniture.Models.Ulti;

namespace VietPhuongAnFurniture.Controllers
{
    //[Authorize(Roles ="Admin")]
    //[AllowAnonymous]

    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;


        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public IActionResult Index(string stuff, string subType, string productType, string price)
        {
            var viewModel = new ViewModel();
            var lstAllProduct = _context.Products.OrderBy(n=>n.CRUDDate).ToList();
            foreach (var item in lstAllProduct)
            {
                var imageObj = _context.ProductImages.FirstOrDefault(i => i.ProductId == item.Id && i.Index == 1);
                if (imageObj == null)
                {
                    imageObj = new ProductImage
                    {
                        // path default.
                        Path = "img/content/product-04.jpg",
                    };
                }
                item.GImage = imageObj;

            }
            var filter = new FilterObj
            {
                Stuff = stuff,
                Subtype = subType,
                ProductType = productType,
                Price = price,
            };
            viewModel.allProducts = GetLstProduct(filter, lstAllProduct);
            viewModel.allBanners = lstAllProduct.Where(n=>n.IsBestSelling == true).Take(10).ToList();
            viewModel.allProductTypes = _context.ProductTypes.ToList();
            viewModel.allProductTypes = _context.ProductTypes.ToList();
            viewModel.allSpecial = lstAllProduct.Take(5).ToList();
            viewModel.allProductSubTypes = _context.ProductSubTypes.ToList();
            viewModel.allStuff = _context.Products.GroupBy(n => n.Stuff).Select(n => n.Key).ToList();
            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public void CreateRole()
        {
            //var apiResponse = new ApiResponseBase();

            try
            {
                var newRole = new IdentityRole();
                newRole.Name = "Admin";
                var roleresult = _roleManager.CreateAsync(new IdentityRole(newRole.Name));
                //apiResponse.MakeTrue("Create Success");

            }
            catch (Exception ex)
            {
                //apiResponse.MakeException(ex.Message);
            }

            //return apiResponse;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Product> GetLstProduct(FilterObj filter, List<Product> lstDefault)
        {
            var lstProduct = new List<Product>();
            lstProduct = lstDefault.Take(100).ToList();
            if (filter.Stuff != null)
                lstProduct = lstDefault.Where(n => n.Stuff.Contains(filter.Stuff)).Take(100).ToList();          

            if (filter.Subtype != null)
                lstProduct = lstDefault.Where(n => n.ProductSubTypeId == filter.Subtype).Take(100).ToList();    

            if (filter.ProductType != null)
                lstProduct = lstDefault.Where(n => n.ProductTypeId == filter.ProductType).Take(100).ToList();
          
            return lstProduct;
        } 
    }
}
