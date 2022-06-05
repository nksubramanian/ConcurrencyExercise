using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = new Task(printNTimes, "subbu");
            t.Start();
            Console.WriteLine("I am here");
            Thread.Sleep(5000);
        }

        public static void printNTimes(object x)
        {
            int i = 1000;
            while(i-->0)
            {
                Console.WriteLine(x);
            }
        }

    }
}
