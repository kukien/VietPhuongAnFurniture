using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    public class Website : BaseModel
    {
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }
    }
}
