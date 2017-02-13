using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp.泛型
{
    public static class 泛型Demo
    {
        public static IAPIData<Product, int> Demo1(string json)
        {
            return Helper.JsonToObject<APIData<Product, int>>(json);
        }

        public static IAPIData<string, float> Demo2(string json)
        {
            return Helper.JsonToObject<APIData<string, float>>(json);
        }
    }

    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
