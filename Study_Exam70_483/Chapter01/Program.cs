using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            bool b = true;
            bool c = true;

            if (b)
            {
                if (c)
                    Console.WriteLine("c is true");
                else
                    Console.WriteLine("b an c are false");
            }
        }
    }
}
