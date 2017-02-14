using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPCSharp.委派.Help;

namespace OOPCSharp.委派
{
    public class Help
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>()
            {
                new Product() { Id=1 ,Cost=11 ,Price=111},
                new Product() { Id=2 ,Cost=22 ,Price=222},
                new Product() { Id=3 ,Cost=33 ,Price=333},
                new Product() { Id=4 ,Cost=44 ,Price=444},
                new Product() { Id=5 ,Cost=55 ,Price=555},
                new Product() { Id=6 ,Cost=66 ,Price=666},
                new Product() { Id=7 ,Cost=77 ,Price=777},
            };

            return products;
        }

        public static List<int> 取得各分頁的最大值(
            List<Product> source,
            int pageSize,
            string columnName)
        {
            List<int> result = new List<int>();

            int tempSize = 0;
            int tempTotalSize = 0;
            int tempValue = 0;

            foreach (var item in source)
            {
                tempSize = tempSize + 1;
                tempTotalSize = tempTotalSize + 1;

                if (columnName == "Cost")
                {
                    tempValue = tempValue > item.Cost
                                ? tempValue
                                : item.Cost;
                }
                else if (columnName == "Price")
                {
                    tempValue = tempValue > item.Price
                                ? tempValue
                                : item.Price;
                }

                if (tempSize == pageSize  //該分頁了
                    || tempTotalSize == source.Count() //最後一頁了
                   )
                {
                    result.Add(tempValue);
                    tempValue = 0;
                    tempSize = 0;
                }
            }

            return result;
        }


















        public static List<int> 取得各分頁的最大值ByFunc(
            List<Product> source,
            int pageSize,
            Func<Product, int> func)
        {
            List<int> result = new List<int>();

            int totalPage = (int)Math.Ceiling((double)source.Count / pageSize);

            for (int Loop = 1; Loop <= totalPage; Loop++)
            {
                var temp = source.Skip((Loop - 1) * pageSize)
                                 .Take(pageSize)
                                 .Max(func);
                result.Add(temp);
            }

            return result;
        }




























        public static List<int> 取得各分頁的最大值ByFunc加泛型<T>(
            List<T> source,
            int pageSize,
            Func<T, int> func)
            where T : class
        {
            List<int> result = new List<int>();

            int totalPage = (int)Math.Ceiling((double)source.Count / pageSize);

            for (int Loop = 1; Loop <= totalPage; Loop++)
            {
                var temp = source.Skip((Loop - 1) * pageSize)
                                 .Take(pageSize)
                                 .Max(func);
                result.Add(temp);
            }

            return result;
        }

        

























        public class Product
        {
            public int Id { get; set; }

            public int Cost { get; set; }

            public int Price { get; set; }
        }


    }
}



























/*
 * 
Help.取得各分頁的最大值ByFunc加泛型(
                  Help.GetOrders(),
                  3,
                  x => x.TotalPrice
            );
public static List<order> GetOrders()
{
    var orders = new List<order>()
            {
                new order() { Id=1 ,TotalPrice=11},
                new order() { Id=2 ,TotalPrice=22},
                new order() { Id=3 ,TotalPrice=33}
            };

    return orders;
}

public class order
{
    public int Id { get; set; }

    public int TotalPrice { get; set; }
}
*/
