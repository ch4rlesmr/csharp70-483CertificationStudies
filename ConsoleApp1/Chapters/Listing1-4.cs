using System;
using System.Threading;

namespace ConsoleApp1
{
    public class Listing1_4
    {
        private bool isRunning = false;
        public Listing1_4()
        {
            RunExample();
        }
        private void ThreadMethod (object obj)
        {
            while (!isRunning)
            {
                Console.WriteLine("Running ...");
                Thread.Sleep(1000);
            }
        }

        private void RunExample() 
        {
            //bool stopped = false;
            //Thread t = new Thread(new ThreadStart(() => {
            //    while (!stopped)
            //    {
            //        Console.WriteLine("Running ...");
            //        Thread.Sleep(1000);
            //    }
            //}));

            Thread t = new Thread(ThreadMethod);


            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            //stopped = true;
            isRunning = true;
            t.Join();
        }
    }
}
