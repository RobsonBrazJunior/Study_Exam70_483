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

            int index = 0;
            while (index < values.Length)
            {
                Console.Write(values[index]);
                index++;
            }
        }
    }
}
