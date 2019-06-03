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
            p.Multicast();
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
    }
}

