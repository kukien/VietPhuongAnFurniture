using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models
{
    [NotMapped]
    public class BaseModel
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
