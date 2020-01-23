using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Chapters
{
    public class Listing1_7
    {
        public Listing1_7()
        {
            RunExample();
        }

        private void RunExample()
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadpool");
            });
        }
    }
}
