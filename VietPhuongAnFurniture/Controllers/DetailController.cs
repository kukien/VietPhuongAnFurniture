using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;
using VietPhuongAnFurniture.Models.Ulti;

namespace VietPhuongAnFurniture.Controllers
{
    public class DetailController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        private static string _folderImages = "ProductImages";
        public DetailController(IHostingEnvironment hostingEnvironment, ApplicationDbContext context)
        {
            _hostingEnvironment = hostingEnvironment;
            _context = context;
        }

        // GET: Detail
        public IActionResult Index()
        {
            var view = new ViewDetailModel();
            var gImage = _context.ProductImages.FirstOrDefault(i => i.Index == 1)?.Path ?? "";
            return View(view);
        }
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Products.ToListAsync());
        //}

        // GET: Detail/Details/5
        public IActionResult Details(string id)
        {
            var view = new ViewDetailModel();
            // General Image
            view.GImage = _context.ProductImages.FirstOrDefault(i => i.ProductId == id && i.Index == 1);
            if (view.GImage == null)
            {
                view.GImage = new ProductImage();
                view.GImage.Path = "ProductImages/700x700.png";
            }
            // Thumblist Image
            view.TImage = _context.ProductImages.Where(n => n.ProductId == id).OrderBy(o => o.Index).ToList();
            if (view.TImage.Count == 0)
            {
                view.TImage.Add(new ProductImage() { Path = "ProductImages/700x700.png" });
                view.TImage.Add(new ProductImage() { Path = "ProductImages/700x700.png" });
                view.TImage.Add(new ProductImage() { Path = "ProductImages/700x700.png" });
                view.TImage.Add(new ProductImage() { Path = "ProductImages/700x700.png" });
            }
            // Product Information
            view.Product = _context.Products.FirstOrDefault(n => n.Id == id);
            if (view.Product != null)
            {
                view.Product.View++;
                _context.SaveChanges();
            }
            return View(view);
        }
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var product = await _context.Products
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(product);
        //}

        // GET: Detail/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Detail/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Code,Origin,Color,Stuff,Size,Price,Status,IsBestSelling,View,Description,CRUDDate,Id,Photos")] Product product, List<IFormFile> img_input)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(string pName, string pCode, string pOrigin, string pColor, string pStuff, string pSize, string pPrice, string pDes, string pBes, List<IFormFile> files, string imgIndex)
        {
            int price = int.TryParse(pPrice, out price) ? price : 0;
            int b = int.TryParse(pBes, out b) ? b : 0;
            bool bestSell = Convert.ToBoolean(b);
            var product = new Product
            {
                Name = pName,
                Code = pCode,
                Origin = pOrigin,
                Color = pColor,
                Stuff = pStuff,
                Size = pSize,
                Price = price,
                Description = pDes,
                CRUDDate = DateTime.Now,
                IsBestSelling = bestSell,
                Status = true,
                View = 1,
            };
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            var lstImg = new List<ProductImage>();
            var folderName = product.Id;
            var webRootPath = _hostingEnvironment.WebRootPath;
            var tempPath = Path.Combine(webRootPath, _folderImages);
            var finalPath = Path.Combine(tempPath, folderName);
            Directory.CreateDirectory(finalPath);
            if (files.Count > 0)
            {
                var indexArr = imgIndex.Split(',');
                var lstPair = new List<CommonModel.KeyPairStr>();
                foreach (var item in indexArr)
                {
                    var str = item.Split(';')[0];
                    int num = int.TryParse(item.Split(';')[1] + "", out num) ? num : 0;
                    if (num > 0)
                    {
                        if (lstPair.FirstOrDefault(n => n.Str == str) != null)
                            str = str + num;
                        lstPair.Add(new CommonModel.KeyPairStr() { Str = str, Num = num });
                    }
                }
                var index = 1;
                foreach (var file in files)
                {
                    var i = lstPair.FirstOrDefault(n => n.Str == file.FileName)?.Num ?? 0;
                    var extension = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"')
                        .Split('.');
                    var fileExtension = extension[1];
                    var fileName = extension[0] + "_" + Guid.NewGuid() + "." + fileExtension;
                    var fullPath = Path.Combine(finalPath, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    lstImg.Add(new ProductImage
                    {
                        ImageName = fileName,
                        Path = _folderImages + "/" + folderName + "/" + fileName,
                        Extension = fileExtension,
                        ProductId = product.Id,
                        CRUDDate = DateTime.Now,
                        Index = i
                    });
                    index++;
                }
            }
            if (lstImg.Count > 0)
            {
                try
                {
                    _context.ProductImages.AddRange(lstImg);
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
            return RedirectToAction("Files");
        }

        // GET: Detail/Edit/5
        public IActionResult Edit(string id)
        {
            var view = new ViewDetailModel();
            view.Product = _context.Products.FirstOrDefault(n => n.Id == id);
            view.ProductImage = _context.ProductImages.Where(n => n.ProductId == id)
                .Select(n => new ProductImageModel
                {
                    Id = n.Id,
                    ImageName = n.ImageName,
                    Extension = n.Extension,
                    Path = n.Path,
                    ProductId = n.ProductId,
                    Index = n.Index,
                    //Base64 = ConvertImageToBase64(n.Path)
                }).OrderBy(o => o.Index).ToList();
            
            return View(view);
        }

        private string ConvertImageToBase64(string path)
        {
            path = path.Replace('/', '\\');
            var webRootPath = _hostingEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, path);
            byte[] imageArray = System.IO.File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageArray);
        }

        // POST: Detail/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Name,Code,Origin,Color,Stuff,Size,Price,Status,IsBestSelling,View,Description,CRUDDate,Id")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> EditProduct(List<IFormFile> fileUploads, string fileDeletes)
        {
            var lstImg = new List<ProductImage>();
            var folderName = "test";
            var webRootPath = _hostingEnvironment.WebRootPath;
            var tempPath = Path.Combine(webRootPath, _folderImages);
            var finalPath = Path.Combine(tempPath, folderName);
            //Directory.CreateDirectory(finalPath);
            //if (fileUploads.Count > 0)
            //{
            //    var index = 1;
            //    foreach (var file in fileUploads)
            //    {
            //        var extension = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"')
            //            .Split('.');
            //        var fileExtension = extension[1];
            //        var fileName = extension[0] + "_" + Guid.NewGuid() + "." + fileExtension;
            //        var fullPath = Path.Combine(finalPath, fileName);
            //        using (var stream = new FileStream(fullPath, FileMode.Create))
            //        {
            //            file.CopyTo(stream);
            //        }
            //        index++;
            //    }
            //}
            return RedirectToAction("Files");
        }

        // GET: Detail/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(string id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
