using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Using a CancellationToken
	public class Listing_1_042
	{
		public static void Main()
		{
			CancellationTokenSource cancellationTokenSoruce = new CancellationTokenSource();
			CancellationToken token = cancellationTokenSoruce.Token;

			Task task = Task.Run(() =>
			{
				while (!token.IsCancellationRequested)
				{
					Console.WriteLine("*");
					Thread.Sleep(1000);
				}
			}, token);

			Console.WriteLine("Press enter to stop the task");
			Console.ReadLine();
			cancellationTokenSoruce.Cancel();

			Console.WriteLine("Press enter to end the application");
			Console.ReadLine();
		}
	}
}
