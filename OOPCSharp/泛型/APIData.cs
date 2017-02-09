using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCSharp.泛型
{
    public interface IAPIData<T, U>
        where T : class
        where U : struct
    {
        string Version { get; set; }

        T Data { get; set; }

        U ErrorCode { get; set; }
    }

    public class APIData<T, U> : IAPIData<T, U>
        where T : class
        where U : struct
    {
        public string Version { get; set; }

        public T Data { get; set; }

        public U ErrorCode { get; set; }
    }
}
