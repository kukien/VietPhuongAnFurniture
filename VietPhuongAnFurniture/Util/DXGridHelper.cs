using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;
using System.Threading.Tasks;
using VietPhuongAnFurniture.Data;
using VietPhuongAnFurniture.Models;
using static VietPhuongAnFurniture.Models.Ulti.EnumHelper;

namespace VietPhuongAnFurniture.Util
{
    public class DxGridHelper
    {
        public static async Task<ApiResponseBase> HandleEdit<T>(ApplicationDbContext context, DxGrvObj obj, bool autoSave = false) where T : BaseModel2
        {
            var respone = new ApiResponseBase();
            var repo = context.Set<T>();

            switch (obj.EditType)
            {
                case DxGrvEditType.Insert:
                    try
                    {
                        var dbInsert = await repo.FirstOrDefaultAsync<T>(p => p.Id == obj.Key);
                        if (dbInsert == null)
                        {
                            dbInsert = Activator.CreateInstance<T>();
                            dbInsert.CRUDDate = DateTime.Now;
                            MappingData<T>(dbInsert, obj);
                            await repo.AddAsync(dbInsert);
                            respone.MakeTrue("Thêm mới thành công");
                        }
                    }
                    catch (Exception ex)
                    {
                        respone.MakeException(ex);
                    }

                    break;
                case DxGrvEditType.Update:
                    try
                    {
                        var dbUpdateObj = await repo.FirstOrDefaultAsync<T>(p => p.Id == obj.Key);
                        dbUpdateObj.CRUDDate = DateTime.Now;
                        MappingData<T>(dbUpdateObj, obj);
                        repo.Update(dbUpdateObj);
                        respone.MakeTrue("Cập nhật thành công");
                    }
                    catch (Exception ex)
                    {
                        respone.MakeException(ex);
                    }
                    break;

                case DxGrvEditType.Delete:
                    try
                    {
                        var dbDeleteObj = await repo.FirstOrDefaultAsync<T>(p => p.Id == obj.Key);
                        MappingData<T>(dbDeleteObj, obj);
                        repo.Remove(dbDeleteObj);
                        respone.MakeTrue("Đã xóa!");
                    }
                    catch (Exception ex)
                    {
                        respone.MakeException(ex);
                    }
                    break;
            }

            if (autoSave)
            {
                await context.SaveChangesAsync();
            }

            return respone;
        }

        protected static bool MappingData<T>(T value, DxGrvObj obj) where T : BaseModel2
        {
            foreach (JToken attribute in obj.Data)
            {
                JProperty jProperty = attribute.ToObject<JProperty>();
                string propertyName = jProperty.Name;

                var prop = value.GetType().GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
                if (null != prop && prop.CanWrite)
                {
                    prop.SetValue(value, jProperty.Value.ToObject(prop.PropertyType));
                }
            }
            return true;
        }
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
   

    public class DxGrvObj
    {
        public DxGrvEditType EditType { get; set; }
        public string Key { get; set; }
        public JToken Data { get; set; }

    }
}
