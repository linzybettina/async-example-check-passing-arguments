using System;
using System.Threading.Tasks;

namespace returningvaluefromtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calling function");
            Task<int> t = Task.Factory.StartNew(() => Add(5000, 10000));
            Console.WriteLine("waiting for results");
            Console.WriteLine(t.Result);
            Console.ReadLine();
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }

        }
    }

