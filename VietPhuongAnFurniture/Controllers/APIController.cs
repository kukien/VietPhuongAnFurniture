using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;
using VietPhuongAnFurniture.Models.Ulti;

namespace VietPhuongAnFurniture.Controllers
{
    public class APIController : Controller
    {
        private readonly ApplicationDbContext _context;

        public APIController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<List<Product>> LoadProductData()
        {
            var lstObj = new List<Product>();
            lstObj = await _context.Products.Select(n => n).ToListAsync();
            foreach (var item in lstObj)
            {
                var imageObj = _context.ProductImages.FirstOrDefault(i => i.ProductId == item.Id && i.Index == 1);
                if (imageObj == null)
                {
                    imageObj = new ProductImage
                    {
                        // path default.
                        Path = "~/ProductImages/70x70.png",
                    };
                }
                item.GImage = imageObj;
                item.SubTypeName = _context.ProductSubTypes.FirstOrDefault(n=>n.Id ==item.ProductSubTypeId)?.Name ??"";
                item.TypeName = _context.ProductTypes.FirstOrDefault(n=>n.Id ==item.ProductTypeId)?.Name ??"";
            }
            return lstObj;
        }

        [Authorize]
        [HttpPost]
        [Route("[controller]/[action]")]
        public ActionResult DeleteProduct([FromBody]string productId)
        {
            var abc = "Abc";
            return Ok();
        }
    }
}