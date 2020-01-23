using System;
using System.Threading;

namespace ConsoleApp1.Chapters
{
    public class Listing1_3
    {
        public Listing1_3()
        {
            RunExample();
        }

        private void ThreadMetod (object obj)
        {
            for (int i = 0; i < (int)obj; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        private void RunExample()
        {
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMetod)); ;
            t.Start(5);
            t.Abort();
            //t.Join();
        }
    }
}
