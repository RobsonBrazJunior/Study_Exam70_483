using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Adding a continuation for canceled tasks
	class Listing_1_044
	{
		static void Main()
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			CancellationToken token = cancellationTokenSource.Token;

			Task task = Task.Run(() =>
			{
				while (!token.IsCancellationRequested)
				{
					Console.Write("*");
					Thread.Sleep(1000);
				}
			}, token).ContinueWith((t) =>
			{
				t.Exception.Handle((e) => true);
				Console.WriteLine("You have canceled the task");
			}, TaskContinuationOptions.OnlyOnCanceled);

			try
			{
				Console.WriteLine("Press enter to stop the task");
				Console.ReadLine();

				cancellationTokenSource.Cancel();
				task.Wait();
			}
			catch (AggregateException e)
			{
				Console.WriteLine(e.InnerExceptions[0].Message);
			}
			Console.WriteLine("Press enter to end the application");
			Console.ReadLine();
		}
	}
}