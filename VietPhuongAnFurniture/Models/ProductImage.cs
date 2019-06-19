using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    public class ProductImage : BaseModel
    {
        public string Path { get; set; }
        public string ImageName { get; set; }
        public string Extension { get; set; }
        public DateTime CRUDDate { get; set; }
        public string ProductId { get; set; }
        public int Index { get; set; }
    }
}
