using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;

namespace VietPhuongAnFurniture.Controllers
{
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
            var productlst = _context.Products.ToList();


            return View(productlst);
        }
        public IActionResult Banner()
        {
            var productlst = _context.Products.ToList();

            return View(productlst);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
