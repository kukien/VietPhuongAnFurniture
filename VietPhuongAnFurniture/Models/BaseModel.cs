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

    public class BaseModel2
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime CRUDDate { get; set; }

    }
}
