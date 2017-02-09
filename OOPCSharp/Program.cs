using OOPCSharp.泛型;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            泛型();
        }
        private static void 泛型()
        {
            var temp = new APIData<Product, int>()
            {
                Version = "V1",
                ErrorCode = 0,
                Data = new Product()
                {
                    ID = 87,
                    Name = "產品"
                }
            };
            var json = Helper.ToJson(temp);
            var a1 = Demo.Demo1(json);

            var temp2 = new APIData<string, float>()
            {
                Version = "V1",
                ErrorCode = 1.1F,
                Data = "發生錯誤"
            };
            json = Helper.ToJson(temp2);
            var a2 = Demo.Demo2(json);


            //實作
            var id = 1.1;
            var typeName1 = id.GetType().Name; //Int32

            Product p = new Product();
            var typeName2 = p.GetType().Name;  //Product

        }
    }
}
