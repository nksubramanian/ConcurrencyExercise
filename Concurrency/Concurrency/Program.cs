using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Task<int>(TextLength,"subbu");
            task.Start();
            //task.Wait();
            Console.WriteLine(task.Result);


        }

        public static int TextLength(object o)
        {
            Thread.Sleep(1000);
            return o.ToString().Length;
        }



    }
}
