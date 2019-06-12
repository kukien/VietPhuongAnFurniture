using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    public class ProductSubType : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CRUDDate { get; set; }
        public string ProductTypeId { get; set; }
    }
}
