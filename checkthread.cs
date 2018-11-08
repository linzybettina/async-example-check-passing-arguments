using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class checkthread
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(WhattypeofThreadamI).Wait();

        }
        private static void WhattypeofThreadamI()
        {
            Console.WriteLine("I am a {0} thread", Thread.CurrentThread.IsThreadPoolThread,"Thread");
            Console.ReadLine();
        }

    }
}
