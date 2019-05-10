using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.IO;

namespace Chapter01
{
    public static class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);
        }
    }
}
