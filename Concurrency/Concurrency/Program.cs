using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextLength("subbu"));
            var task = Task.Run(() => { return TextLength("subbu"); });
            var awaiter = task.GetAwaiter();
            var result = awaiter.GetResult();


        }

        public static int TextLength(object o)
        {
            return o.ToString().Length;
        }



    }
}
