using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => printNTimes());
            Thread.Sleep(1000);
        }

        public static void printNTimes()
        {
            int i = 1000;
            while(i-->0)
            {
                Console.WriteLine(i);
            }
        }

    }
}
