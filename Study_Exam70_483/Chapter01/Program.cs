using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }
            }, token).ContinueWith((t) =>
             {
                 t.Exception.Handle((e) => true);
                 Console.WriteLine("You have canceled the task");
             }, TaskContinuationOptions.OnlyOnCanceled);
        }
    }
}
