using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            bool b = false;
            bool c = true;

            if (b)
                Console.WriteLine("b is true");
            else if (c)
                Console.WriteLine("c is true");
            else
                Console.WriteLine("b an c are false");
        }
    }
}
