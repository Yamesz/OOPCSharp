using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPCSharp.委派.ValueType_ReferenceType;

namespace OOPCSharp.委派
{
    public class T3
    {
        public void demo1()
        {

            Action<string> a4 = x => { var t = x + "M5"; };
        }
        public List<int> M1(List<int> bookList)
        {
            return bookList;
        }

        public string M2(int id , DateTime date)
        {
            return string.Empty;
        }

        public DateTime M3()
        {
            return DateTime.Now;
        }

        public void M4(string name)
        {
            var t = name + "M5";
        }
    }
}

