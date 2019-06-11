using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models.Ulti
{
    public class ProductImageModel
    {
        public string Id { get; set; }
        public string Path { get; set; }
        public string ImageName { get; set; }
        public string Extension { get; set; }
        public DateTime CRUDDate { get; set; }
        public string ProductId { get; set; }
        public int Index { get; set; }
        public string Base64 { get; set; }
    }
}
