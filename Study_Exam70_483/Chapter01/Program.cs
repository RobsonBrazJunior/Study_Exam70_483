using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            Program p = new Program();
            p.UseDelegate();
        }

        public delegate int Calcualte(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public void UseDelegate()
        {
            Calcualte calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3,4));
        }
    }
}

