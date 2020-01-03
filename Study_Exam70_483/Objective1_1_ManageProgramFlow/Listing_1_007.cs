using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Queuing some work to the thread pool
	public static class Listing_1_007
	{
		public static void Main()
		{
			ThreadPool.QueueUserWorkItem((s) =>
			{
				Console.WriteLine("Working on a thread from threadpool");
			});

			Console.ReadLine();
		}
	}
}
