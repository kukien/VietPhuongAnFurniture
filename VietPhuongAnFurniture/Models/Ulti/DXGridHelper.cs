using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietPhuongAnFurniture.Models.Ulti
{
    public class DXGridHelper
    {
    }
    public class ApiResponseBase
    {
        public bool IsOk { get; set; } = false;
        public string Msg { get; set; } = "Unknown Error";
        public string StatusStr { get; set; } = "error";
        public string Key { get; set; } = null;
        public string Creater { get; set; } = null;
        public virtual void MakeTrue(string msg = "ActionOk")
        {
            IsOk = true;
            StatusStr = "success";
            Msg = msg;
        }
        public virtual void MakeTrueReturnKey(string msg = "ActionOk", string key = null, string creater = null)
        {
            IsOk = true;
            StatusStr = "success";
            Msg = msg;
            Key = key;
            Creater = creater;
        }
        public virtual void MakeException(Exception ex)
        {
            IsOk = false;
            StatusStr = "error";
            Msg = ex.Message;
        }
        public virtual void MakeException(string msg)
        {
            IsOk = false;
            StatusStr = "error";
            Msg = msg;
        }
    }
}
