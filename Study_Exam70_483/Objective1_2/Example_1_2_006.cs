using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_006
	{
		static void Main(string[] args)
		{
			CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
			CancellationToken cancellationToken = cancellationTokenSource.Token;
			int theCount = 0;
			Console.WriteLine("Task running... Count from 0 to...");
			Console.WriteLine("Press ENTER to interrupt the execution!");

			Task theIncredibleTask = Task.Run(() =>
			{
				while (!cancellationToken.IsCancellationRequested)
				{
					Thread.Sleep(1000);
					Console.WriteLine(theCount.ToString());
					theCount++;
				}
			}, cancellationToken);

			Console.ReadLine();
			cancellationTokenSource.Cancel();

			Console.WriteLine("Execution cancelled!");
			Console.ReadLine();
		}
	}
}
