using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	class Listing_1_045
	{
		public static void Main()
		{
			Task longRunning = Task.Run(() =>
			{
				Thread.Sleep(10000);
			});

			int index = Task.WaitAny(new[] { longRunning }, 1000);

			if (index == -1)
				Console.WriteLine("Task timed out");
		}
	}
}
