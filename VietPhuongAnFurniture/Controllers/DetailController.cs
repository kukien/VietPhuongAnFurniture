using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
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
            // Product Information
            view.Product = _context.Products.FirstOrDefault(n => n.Id == id);
            //if (view.Product != null)
            //{
            //    view.Product.View++;
            //    _context.SaveChanges();
            //}
            // General Image
            view.GImage = _context.ProductImages.FirstOrDefault(i => i.ProductId == id && i.Index == 1);
            if (view.GImage == null)
            {
                view.GImage = new ProductImage();
                view.GImage.Path = "~/ProductImages/700x700.png";
            }
            else
            {
                view.GImage.Path = view.GImage.Path;
            }
            // Thumblist Image
            view.TImage = _context.ProductImages.Where(n => n.ProductId == id).OrderBy(o => o.Index).ToList();
            if (view.TImage.Count == 0)
            {
                view.TImage.Add(new ProductImage() { Path = "~/ProductImages/700x700.png" });
                view.TImage.Add(new ProductImage() { Path = "~/ProductImages/700x700.png" });
                view.TImage.Add(new ProductImage() { Path = "~/ProductImages/700x700.png" });
                view.TImage.Add(new ProductImage() { Path = "~/ProductImages/700x700.png" });
            }
            else
            {
                view.TImage = view.TImage.Select(c =>
                {
                    c.Path = c.Path;
                    return c;
                }).ToList();
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
        public IActionResult ProductType()
        {
            return View();
        }

        public IActionResult ProductSubType()
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
                        Path = "~/" + _folderImages + "/" + folderName + "/" + fileName,
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
        public IActionResult EditProduct(string productId, string pName, string pCode, string pOrigin, string pColor, string pStuff, string pSize, string pPrice, string pDes, string pBes, List<IFormFile> fileUploads, List<string> fileDeletes, string imgIndex, string imgOrders)
        {
            var product = _context.Products.FirstOrDefault(n => n.Id == productId);
            var lstImg = new List<ProductImage>();
            if (product != null)
            {
                int price = int.TryParse(pPrice, out price) ? price : 0;
                int b = int.TryParse(pBes, out b) ? b : 0;
                bool bestSell = Convert.ToBoolean(b);
                // Update Product
                product.Name = pName;
                product.Code = pCode;
                product.Origin = pOrigin;
                product.Code = pCode;
                product.Stuff = pStuff;
                product.Size = pSize;
                product.Price = price;
                product.Description = pDes;
                product.IsBestSelling = bestSell;
                _context.SaveChanges();
                // Update order image
                var orderArr = imgOrders.Split(',');
                var orderLst = new List<CommonModel.KeyPairStr>();
                orderLst = orderArr.Select(n => new CommonModel.KeyPairStr
                {
                    Num = ParseInt32(n.Split(';')[0]),
                    Str = n.Split(';')[1],
                }).ToList();
                var lstImgOrder = _context.ProductImages.Where(n => n.ProductId == product.Id).ToList();
                lstImgOrder = lstImgOrder.Select(c =>
                {
                    var num = orderLst.FirstOrDefault(n => n.Str == c.Id)?.Num ?? 0;
                    c.Index = num;
                    return c;
                }).ToList();
                _context.SaveChanges();
                // Delete image
                if (fileDeletes.Count > 0)
                {
                    var lstImgRemove = new List<ProductImage>();
                    foreach (var idImgDelete in fileDeletes)
                    {
                        var imgDeleteObj = _context.ProductImages.FirstOrDefault(n => n.Id == idImgDelete);
                        if (imgDeleteObj != null)
                        {
                            DeleteFile(imgDeleteObj.Path, "img");
                            lstImgRemove.Add(imgDeleteObj);

                        }
                    }
                    _context.ProductImages.RemoveRange(lstImgRemove);
                    _context.SaveChanges();
                    // Order image
                    var lstImgAvailable = _context.ProductImages.Where(p => p.ProductId == product.Id).OrderBy(o => o.Index).ToList();
                    var indexUpdate = 1;
                    lstImgAvailable = lstImgAvailable.Select(c =>
                    {
                        c.Index = indexUpdate;
                        indexUpdate++;
                        return c;
                    }).ToList();
                    _context.SaveChanges();
                }
                // Add image
                //Directory.CreateDirectory(finalPath);
                if (fileUploads.Count > 0)
                {
                    // Get root path
                    var folderName = product.Id;
                    var webRootPath = _hostingEnvironment.WebRootPath;
                    var tempPath = Path.Combine(webRootPath, _folderImages);
                    var finalPath = Path.Combine(tempPath, folderName);
                    // Handle index image
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
                    // Number image available in project
                    var imgCount = lstImgOrder.Count();
                    foreach (var file in fileUploads)
                    {
                        var i = (lstPair.FirstOrDefault(n => n.Str == file.FileName)?.Num ?? 0) + imgCount;
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
                            Path = "~/" + _folderImages + "/" + folderName + "/" + fileName,
                            Extension = fileExtension,
                            ProductId = product.Id,
                            CRUDDate = DateTime.Now,
                            Index = i
                        });
                    }
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
            return RedirectToAction("Success");
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

        [HttpPost]
        public IActionResult DeleteProduct(string productId)
        {
            var product = _context.Products.FirstOrDefault(n => n.Id == productId);
            if (product != null)
            {
                var imgLst = _context.ProductImages.Where(n => n.ProductId == productId).ToList();
                if (imgLst.Count > 0)
                {
                    _context.ProductImages.RemoveRange(imgLst);
                    _context.SaveChanges();
                }
                var path = _folderImages + "/" + product.Id;
                DeleteFile(path, "folder");
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return Json("delete success");
        }

        private bool ProductExists(string id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        private void DeleteFile(string path, string type)
        {
            if (path.Contains("~/"))
                path = path.Substring(2, path.Length - 2);
            path = path.Replace('/', '\\');
            try
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                string finalPath = Path.Combine(webRootPath, path);
                if (type == "img")
                    System.IO.File.Delete(finalPath);
                else if (type == "folder")
                    Directory.Delete(finalPath, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Int32 ParseInt32(string str)
        {
            int result;
            return Int32.TryParse(str, out result) ? result : 0;
        }
    }
}
