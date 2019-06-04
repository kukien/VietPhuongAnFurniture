﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    public class Product : BaseModel
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(20)]
        public string Code { get; set; }
        [MaxLength(100)]
        public string Origin { get; set; }
        [MaxLength(50)]
        public string Color { get; set; }
        [MaxLength(100)]
        public string Stuff { get; set; }
        [MaxLength(50)]
        public string Size { get; set; }
        public double Price { get; set; }
        public bool Status { get; set; }
        public bool IsBestSelling { get; set; }
        public int View { get; set; }
        public string Description { get; set; }
        public DateTime CRUDDate { get; set; }
    }
}