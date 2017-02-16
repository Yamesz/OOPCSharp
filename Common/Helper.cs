using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Helper
    {
        public static T JsonToObject<T>(string json)
           where T : new()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                return new T();
            }
        }

        public static string ToJson<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }


        //實作
        //public static XXXX GetTypeName xxxxxxx
        //{
        //    return XXXXX
        //}
    }
}
