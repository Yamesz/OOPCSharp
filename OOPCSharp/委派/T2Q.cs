using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPCSharp.委派.ValueType_ReferenceType;

namespace OOPCSharp.委派
{
    public class T2Q
    {
        public void Demo1()
        {
            Func<float, double> func = Method;
            Demo2(func);
        }

        public void Demo2(Func<float, double> f)
        {
            var result = f(10.1F);
        }

        public double Method(float x)
        {
            var temp = x;
            Console.WriteLine(temp);
            return temp;
        }
    }
}

