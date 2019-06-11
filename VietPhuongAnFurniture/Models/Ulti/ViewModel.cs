using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    [NotMapped]
    public class ViewModel
    {
        public List<Product> allProducts { get; set; }
        public List<Product> allBanners { get; set; }
        public List<Product> allSpecial { get; set; }
        public List<ProductType> allProductTypes { get; set; }
       
    }
}
