using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = Task.Factory.StartNew<int>(TextLength, "subramanian");
            Console.WriteLine("SUBBU");
            Console.WriteLine(task.Result);


        }

        public static int TextLength(object o)
        {
            Thread.Sleep(1000);
            Console.WriteLine(Task.CurrentId);
            return o.ToString().Length;
        }



    }
}
