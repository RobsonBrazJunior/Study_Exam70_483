using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Scheduling different continuation tasks
	public static class Listing_1_011
	{
		public static void Main()
		{
			Task<int> t = Task.Run(() =>
			{
				return 42;
			});

			t.ContinueWith((i) =>
			{
				Console.WriteLine("Canceled");
			}, TaskContinuationOptions.OnlyOnCanceled);

			t.ContinueWith((i) =>
			{
				Console.WriteLine("Faulted");
			}, TaskContinuationOptions.OnlyOnFaulted);

			var completedTask = t.ContinueWith((i) =>
			{
				Console.WriteLine("Completed");
			}, TaskContinuationOptions.OnlyOnRanToCompletion);

			completedTask.Wait();
		}
	}
}
