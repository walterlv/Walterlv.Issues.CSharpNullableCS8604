using System;
using System.Threading.Tasks;

namespace Walterlv.Issues.CSharpNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = GetNotNullObject();
            Task.Run(() => Run());
            void Run() => VerifyNotNull(foo);
        }

        private static object GetNotNullObject() => new object();

        private static bool VerifyNotNull(object instance) => instance != null;
    }
}
