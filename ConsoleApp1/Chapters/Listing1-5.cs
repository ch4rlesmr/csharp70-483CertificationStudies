using System;
using System.Threading;

namespace ConsoleApp1.Chapters
{
    public class Listing1_5
    {
        [ThreadStatic]
        public static int _field;

        public Listing1_5()
        {
            RunExample();
        }

        public void RunExample()
        {
            var A = new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                    Thread.Sleep(500);
                }
            });

            var B = new Thread(() => {
                _field = 10;
                for (int x = 10; x < 20; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                    Thread.Sleep(500);
                }
            });

            A.Start();
            B.Start();

            A.Join();
            B.Join();
        }
    }
}
