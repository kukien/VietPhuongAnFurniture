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
        public IActionResult Index()
        {
            var viewModel = new ViewModel();
            var lstAllProduct = _context.Products.OrderBy(n=>n.CRUDDate).ToList();
            viewModel.allProducts = lstAllProduct.Take(100).ToList();
            viewModel.allBanners = lstAllProduct.Where(n=>n.IsBestSelling == true).Take(10).ToList();
            viewModel.allProductTypes = _context.ProductTypes.ToList();
            viewModel.allSpecial = lstAllProduct.Take(5).ToList();
            //CreateRole();
            return View(viewModel);
        }
        //public IActionResult Banner()
        //{
        //    var productlst = _context.Products.ToList();

        //    return View(productlst);
        //}

        //public IActionResult Categories()
        //{
        //    var categorizes = _context.Categorizes.ToList();

        //    return View(categorizes);
        //}
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
    }
}
