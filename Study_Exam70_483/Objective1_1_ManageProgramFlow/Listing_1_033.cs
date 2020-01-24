using System;
using System.Collections.Concurrent;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	public static class Listing_1_033
	{
		public static void Main()
		{
			ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
			queue.Enqueue(42);

			int result;
			if (queue.TryDequeue(out result))
				Console.WriteLine("Dequeued: {0}", result);
		}
	}
}
