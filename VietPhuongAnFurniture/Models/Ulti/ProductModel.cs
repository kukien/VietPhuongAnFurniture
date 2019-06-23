﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace VietPhuongAnFurniture.Models.Ulti
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Origin { get; set; }
        public string Color { get; set; }
        public string Stuff { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public double Price2 { get; set; }
        public bool Status { get; set; }
        public bool IsBestSelling { get; set; }
        public int View { get; set; }
        public string Description { get; set; }
        public DateTime CRUDDate { get; set; }
        public IFormFile Photos { get; set; }
        public string ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductSubTypeId { get; set; }
        public string ProductSubTypeName { get; set; }
    }
}
