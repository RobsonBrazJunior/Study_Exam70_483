﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public static class Program
    {
        static int value = 1;

        public static void Main()
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    // Removing the folloing line will change the output
                    Thread.Sleep(1000);
                    value = 2;
                }
            });

            Task t2 = Task.Run(() =>
            {
                value = 3;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value); // Displays 2
        }
    }
}
