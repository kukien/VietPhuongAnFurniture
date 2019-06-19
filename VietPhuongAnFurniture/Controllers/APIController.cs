using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;
using VietPhuongAnFurniture.Models.Ulti;
using VietPhuongAnFurniture.Util;

namespace VietPhuongAnFurniture.Controllers
{
    public class APIController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        private static string _folderImages = "ProductImages";

        public APIController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
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
                item.SubTypeName = _context.ProductSubTypes.FirstOrDefault(n => n.Id == item.ProductSubTypeId)?.Name ?? "";
                item.TypeName = _context.ProductTypes.FirstOrDefault(n => n.Id == item.ProductTypeId)?.Name ?? "";
            }
            return lstObj;
        }

        [Authorize]
        [HttpPost]
        [Route("[controller]/[action]")]
        public async Task<ApiResponseBase> DeleteProduct([FromBody]string productId)
        {
            var apiResponse = new ApiResponseBase();
            try
            {
                var product = await _context.Products.FirstOrDefaultAsync(n => n.Id == productId);
                if (product != null)
                {
                    var path = _folderImages + "/" + product.Id;
                    DeleteFile(path, "folder");
                    var imgLst = _context.ProductImages.Where(n => n.ProductId == productId).ToList();
                    if (imgLst.Count > 0)
                    {
                        _context.ProductImages.RemoveRange(imgLst);
                        _context.SaveChanges();
                    }
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    apiResponse.MakeTrue("Xóa thành công");
                }
                else
                {
                    apiResponse.MakeTrue("Có lỗi xảy ra, không thể xóa sản phẩm!");
                }

            }
            catch (Exception ex)
            {
                apiResponse.MakeException(ex.Message);
            }
            return apiResponse;

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
                bool exists = Directory.Exists(finalPath);
                if (type == "img")
                    System.IO.File.Delete(finalPath);
                else if (type == "folder")
                    if (Directory.Exists(finalPath)) Directory.Delete(finalPath, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [Authorize]
        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<List<ProductType>> LoadProductType()
        {
            var lstObj = new List<ProductType>();
            lstObj = await _context.ProductTypes.Select(n => n).ToListAsync();
            return lstObj;
        }

        [Authorize]
        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<List<ProductSubType>> LoadProductSubType()
        {
            var lstObj = new List<ProductSubType>();
            lstObj = await _context.ProductSubTypes.Select(n => n).ToListAsync();
            return lstObj;
        }

        [Authorize]
        [HttpPost]
        [Route("[controller]/[action]")]
        public async Task<ApiResponseBase> SaveProductType([FromBody]DxGrvObj reqPath)
        {
            return await DxGridHelper.HandleEdit<ProductType>(_context, reqPath, true);
        }

        [Authorize]
        [HttpPost]
        [Route("[controller]/[action]")]
        public async Task<ApiResponseBase> SaveProductSubType([FromBody]DxGrvObj reqPath)
        {
            return await DxGridHelper.HandleEdit<ProductSubType>(_context, reqPath, true);
        }

        [Authorize]
        [HttpGet]
        [Route("[controller]/[action]")]
        public async Task<Banner> GetBanner()
        {
            var bannerObj = await _context.Banners.FirstOrDefaultAsync();
            if (bannerObj == null)
            {
                bannerObj = new Banner();

                bannerObj.Content = "";
                bannerObj.ImageUrl = "~/img/content/870x370.png";
            }
            return bannerObj;
        }

        [Authorize]
        [HttpPost]
        [Route("[controller]/[action]")]
        public async Task<ApiResponseBase> SaveBanner(string content, IFormFile file)
        {
            var result = new ApiResponseBase();
            try
            {
                var bannerObj = _context.Banners.FirstOrDefault();
                var webRootPath = _hostingEnvironment.WebRootPath;
                var tempPath = Path.Combine(webRootPath, "img\\content");
                var imageURl = bannerObj?.ImageUrl??"";
                if (file != null)
                {
                    var extension = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"')
                       .Split('.');
                    var fileExtension = extension[1];
                    var fileName = Guid.NewGuid() + "." + fileExtension;
                    var fullPath = Path.Combine(tempPath, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    imageURl = "~/img/content/" + fileName;
                }

                if (bannerObj == null)
                {
                    bannerObj = new Banner
                    {
                        Content = content,
                        ImageUrl = imageURl,
                    };
                    _context.Banners.Add(bannerObj);
                }
                else
                {
                    bannerObj.Content = content;
                    bannerObj.ImageUrl = imageURl;
                }
                _context.SaveChanges();
                result.MakeTrue("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                result.MakeException("Đã có lỗi xảy ra vui lòng thử lại");

            }
            return result;
            //return await DxGridHelper.HandleEdit<ProductType>(_context, reqPath, true);
        }
    }
}