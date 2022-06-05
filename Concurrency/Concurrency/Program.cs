using System;
using System.Threading;
using System.Threading.Tasks;

namespace Concurrency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var task = Task.Run(() => { printNTimes();});
            Task.WaitAll(task);
            //Thread.Sleep(3000);
            Console.WriteLine("Hello World!");
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
