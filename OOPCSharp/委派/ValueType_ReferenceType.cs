using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp.委派
{
    public class ValueType_ReferenceType
    {
        public void Demo1()
        {
            var i = 5;
            var o = new Order()
            {
                ID = 9,
                Name = 'a'
            };

            Method(o, i);
            Console.WriteLine(i);
            Console.WriteLine(o.ID);
            Console.WriteLine(o.Name);
        }

        private void Method(Order no, int ni)
        {
            ni = 6;
            no.ID = 10;
            no.Name = 'b';
        }

        public class Order
        {
            public int ID { get; set; }

            public char Name { get; set; }
        }
    }
}
