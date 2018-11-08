using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingargumentsex
{
    class passingargument
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => Speak("hello world")).Wait();
        }
        private static void Speak (string words)
        {
            Console.WriteLine(words);
            Console.ReadLine();

        }

    }
}
