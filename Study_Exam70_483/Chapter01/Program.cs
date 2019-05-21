using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(1000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if (index == -1)
                Console.WriteLine("Task timed out");
        }
    }
}
