﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPCSharp.委派.ValueType_ReferenceType;

namespace OOPCSharp.委派
{
    public class LambdaExpressionDemo
    {
        public void Demo1()
        {
            //匿名方法
            Func<int, string> doo1 = delegate (int x)
            {
                var temp = x.ToString();
                Console.WriteLine(temp);
                return temp;
            };

            //陳述式 Lambda
            Func<int, string> doo2 = x =>
            {
                var temp = x.ToString();
                Console.WriteLine(temp);
                return temp;
            };

            //運算式 Lambda
            Func<int, string> doo3 = x=> x.ToString();

            string result2 = doo3(5);
            Demo2(doo3);
        }

        public void Demo2(Func<int, string> d)
        {
            string result2 = d(10);
        }
    }
}



