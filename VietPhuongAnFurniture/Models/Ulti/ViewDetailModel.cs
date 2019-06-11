using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietPhuongAnFurniture.Models.Ulti
{
    [NotMapped]
    public class ViewDetailModel
    {
        public ProductImage GImage { get; set; }
        public List<ProductImage> TImage { get; set; }
        public Product Product { get; set; }
        //public IEnumerable<ProductImageModel> ProductImage { get; set; }
        public IEnumerable<ProductImageModel> ProductImage { get; set; }
    }
}
