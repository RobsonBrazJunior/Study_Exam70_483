using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            foreach (int i in values)
            {
                Console.Write(i);
            }
        }
    }
}
