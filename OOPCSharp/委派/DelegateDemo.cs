using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPCSharp.委派.ValueType_ReferenceType;

namespace OOPCSharp.委派
{
    public class DelegateDemo
    {
        //定義 委派型別
        public delegate string MyDelegate(int x);
        public delegate int Func(float x);

        public void Demo1()
        {
            //完整寫法
            MyDelegate doo = new MyDelegate(Method);
            //doo += Method2;
            //doo -= Method;

            string result = doo.Invoke(5);

            //可簡寫 (通常都用簡寫)
            MyDelegate doo2 = Method;
            string result2 = doo(5);
           
            Demo2(doo2);
        }

        //方法當做參數傳
        //MyDelegate 表示 我要傳入一個int 跟回傳string的方法
        public void Demo2(MyDelegate d)
        {
            string result2 = d(10);
        }

        public void Demo3(int a ,Order o,MyDelegate d)
        {
        }

        public string Method(int x)
        {
            var temp = x.ToString();
            Console.WriteLine(temp);
            return temp;
        }

        public string Method2(int x)
        {
            var temp = x.ToString() + "AA";
            Console.WriteLine(temp);
            return temp;
        }


    }
}

