using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    public class Categorize : BaseModel
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CRUDDate { get; set; }
    }
}
