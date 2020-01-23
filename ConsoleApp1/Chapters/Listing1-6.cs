using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Chapters
{
    public class Listing1_6
    {
        public static ThreadLocal<int> _field =
            new ThreadLocal<int>(() => {
                return Thread.CurrentThread.ManagedThreadId;
            });

        public Listing1_6()
        {
            RunExample();
        }

        private void RunExample()
        {
            Console.WriteLine("Thread A => {0}", Thread.CurrentThread.ManagedThreadId);
            new Thread(() => {
                Console.WriteLine("Thread A => {0}", _field.Value);
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() => {
                Console.WriteLine("Thread B => {0}", _field.Value);
                for (int x = 0; x < _field.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
        }
    }
}
