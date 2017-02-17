using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IHelper
    {
        string GetMeBoo(string x);
    }


    public class Helper :IHelper
    {
        public int publicInt { get; set; }

        private string privateString { get; set; }

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

        public static string GetMeFoo(string x)
        {
            return $"Foo{{{x}}}";
        }

        public string GetMeBoo(string x)
        {
            return $"Boo{{{x}}}";
        }


        //實作
        //public static XXXX GetTypeName xxxxxxx
        //{
        //    return XXXXX
        //}
    }
}
