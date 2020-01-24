using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_007
	{
		static void Main(string[] args)
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			CancellationToken token = cancellationTokenSource.Token;
			int theCount = 0;

			Console.WriteLine("Task running... Count from 0 to...");
			Console.WriteLine("Press ENTER to interrupt the execution!");

			Task theIncredibleTask = Task.Run(() =>
			{
				while (!token.IsCancellationRequested)
				{
					Thread.Sleep(1000);
					Console.WriteLine(theCount.ToString());
					theCount++;
				}
			}, token)
			.ContinueWith(task =>
			{
				Console.WriteLine("You just cancelled the theIncredibleTask task! :(");
			}, TaskContinuationOptions.OnlyOnRanToCompletion);

			Console.ReadLine();
			cancellationTokenSource.Cancel();

			try
			{
				theIncredibleTask.Wait(token);
			}
			catch (OperationCanceledException ex)
			{
				Console.WriteLine("The end!");
			}

			Console.ReadLine();
		}
	}
}
