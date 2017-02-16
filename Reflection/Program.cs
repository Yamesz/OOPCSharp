using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            // load by Assembly name
            AssemblyName name = new AssemblyName("TestLibrary01");
            Assembly asm = Assembly.Load(name);
            Console.WriteLine(asm.FullName);


            Assembly asm2 = Assembly.Load("TestLibrary02");
            Console.WriteLine(asm2.FullName);
        }
    }
}
