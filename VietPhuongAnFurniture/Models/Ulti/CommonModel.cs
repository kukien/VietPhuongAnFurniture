using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models.Ulti
{
    public class CommonModel
    {
        public class KeyPairStr
        {
            public int Num { get; set; }
            public string Str { get; set; }
        }

        public class DxGrvObj
        {
            public int EditType { get; set; }
            public string Key { get; set; }
            public JToken Data { get; set; }

        }
    }
}
