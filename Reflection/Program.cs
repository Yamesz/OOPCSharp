using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============load by Assembly name===============");
            AssemblyName name = new AssemblyName("Common");
            Assembly asm = Assembly.Load(name);
            Console.WriteLine(asm.FullName);


            Console.WriteLine("=============load by assembly string===============");
            Assembly asm2 = Assembly.Load("Common");
            Console.WriteLine(asm2.FullName);

            Object obj = asm.CreateInstance("Common.Helper");
            Console.WriteLine(obj.GetType().ToString());

            Console.WriteLine("============CreateInstance================");
            ObjectHandle objhandle = AppDomain.CurrentDomain.CreateInstance("Common", "Common.Helper");
            Console.WriteLine(objhandle.GetType().ToString());
            Console.WriteLine(objhandle.Unwrap().GetType().ToString());

            Console.WriteLine("============CreateInstanceAndUnwrap================");
            Object obj1 = AppDomain.CurrentDomain.CreateInstanceAndUnwrap("Common", "Common.Helper");
            Console.WriteLine(obj1.GetType().ToString());

          

            MemberInfo[] members;
            MethodInfo[] methods;
            PropertyInfo[] propertites;

            Console.WriteLine("==GetMembers()==");
            //沒有參數就是公用成員
            members = obj1.GetType().GetMembers();
            ShowResult(members);


            Console.WriteLine("==GetMembers() BindingFlag==");
            members = obj1.GetType().GetMembers(BindingFlags.Instance | BindingFlags.NonPublic);
            ShowResult(members);

            Console.WriteLine("==GetMember(GetMeFoo)==");
            members = obj1.GetType().GetMember("GetMe*");
            ShowResult(members);

            Console.WriteLine("==GetMethods()==");
            methods = obj.GetType().GetMethods();
            ShowResult(methods);
            //執行方法
            Console.WriteLine("==Invoke GetMeFoo==");
            MethodInfo method = methods.Where((x) => x.Name == "GetMeFoo").FirstOrDefault();

            var a = method.Invoke(obj, new object[] { "ABC" });
            Console.WriteLine($"GetMeFoo return {a}");

            Console.WriteLine("==Invoke GetMeBoo==");
            MethodInfo method2 = methods.Where((x) => x.Name == "GetMeBoo").FirstOrDefault();

            var b = method2.Invoke(obj, new object[] { "RRR" });
            Console.WriteLine($"GetMeFoo return {b}");

            Console.WriteLine("==GetProperties()==");
            propertites = obj.GetType().GetProperties();
            ShowResult(propertites);


            Console.WriteLine("==GetProperties() BindingFlag==");
            propertites = obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
            ShowResult(propertites);

            PropertyInfo property = obj.GetType().GetProperty("privateString", BindingFlags.Instance | BindingFlags.NonPublic);
            Console.WriteLine("屬性原來的值 :" + property.GetValue(obj)?.ToString());
            property.SetValue(obj, "反射SetValue");
            Console.WriteLine("屬性更改後的值 :" + property.GetValue(obj).ToString());

            Type[] types;
            Console.WriteLine("==GetInterfaces()==");
            types = obj.GetType().GetInterfaces();
            ShowResult(types);

            Console.WriteLine("==GetInterface()==");
            Type type = obj.GetType().GetInterface("IHelper", true);
            var c =  type.GetMethods()[0].Invoke(obj, new object[] { "介面" });
            Console.WriteLine($"IHelper array index 0 Method return {c}");

            Console.ReadLine();
        }

        static void ShowResult(MemberInfo[] members)
        {
            foreach (var m in members)
            {
                Console.WriteLine(m.MemberType.ToString() + ":" + m.Name);
            }
            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }
}
