using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPCSharp.委派.ValueType_ReferenceType;

namespace OOPCSharp.委派
{
    public class FuncDemo
    {
        public void Demo1()
        {
            Func<int, string> doo = Method;
            string result2 = doo(5);
            Demo2(doo);
        }

        public void Demo2(Func<int, string> d)
        {
            string result2 = d(10);
        }

        public string Method(int x)
        {
            var temp = x.ToString();
            Console.WriteLine(temp);
            return temp;
        }
    }
}

//定義 委派型別
//public delegate string Func(int x);
//public Func<int, string> doo;




