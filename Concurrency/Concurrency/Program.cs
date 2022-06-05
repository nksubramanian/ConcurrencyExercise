using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(printNTimes, 100);
            Thread.Sleep(100);
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
