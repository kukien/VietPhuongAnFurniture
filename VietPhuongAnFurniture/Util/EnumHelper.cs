using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models.Ulti
{
    public class EnumHelper
    {
        public enum DxGrvEditType
        {
            Insert = 0,
            Update = 1,
            Delete = 2
        }

        public enum UserRole
        {
            View = 0,
            Delete = 1,
            Remove = 2,
        }

        public enum UserRank
        {
            Admin = 0,
            GroupManager = 1,
            User = 2,
        }
    }
}
