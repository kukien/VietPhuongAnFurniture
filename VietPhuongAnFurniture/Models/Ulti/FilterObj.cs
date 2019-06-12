using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models.Ulti
{
    [NotMapped]
        
    public class FilterObj
    {
        public string Stuff { get; set; }
        public string Subtype { get; set; }
        public string ProductType { get; set; }
        public string Price { get; set; }
    }
}
