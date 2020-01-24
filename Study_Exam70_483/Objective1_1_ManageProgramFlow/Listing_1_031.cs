using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	public static class Listing_1_031
	{
		public static void Main()
		{
			ConcurrentBag<int> bag = new ConcurrentBag<int>();
			Task.Run(() =>
			{
				bag.Add(42);
				Thread.Sleep(1000);
				bag.Add(21);
			});

			Task.Run(() =>
			{
				foreach (int i in bag)
					Console.WriteLine(i);
			}).Wait();
		}
	}
}
