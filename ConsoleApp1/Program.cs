using ConsoleApp1.Chapters;
using System;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Method: {0}", i);
                System.Diagnostics.Debug.WriteLine("thread Method: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void ThreadMethodWithParameter(object obj)
        {
            Console.WriteLine(obj.ToString());
            for (int i = 0; i < (int)obj ; i++)
            {
                Console.WriteLine("Thread Method: {0}", i);
                System.Diagnostics.Debug.WriteLine("thread Method: {0}", i);
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            //new Listing1_3();
            //new Listing1_4();
            //new Listing1_5();
            //new Listing1_6();
            new Listing1_7();

            Console.WriteLine("! final ");
            Console.ReadKey();
        }
    }
}
