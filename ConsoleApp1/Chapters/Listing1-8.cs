using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Chapters
{
    class Listing1_8
    {
        public Listing1_8()
        {
            RunExample();
        }

        private void RunExample()
        {
            var t = new Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.WriteLine("*");
                }
            }); ;

            t.Wait();
        }
    }
}
