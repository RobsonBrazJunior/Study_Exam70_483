using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chapter01
{
    public static class Program
    {
        public static void Main()
        {
            Task t = Task.Run(() => {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
            });

            t.Wait();
        }
    }
}
