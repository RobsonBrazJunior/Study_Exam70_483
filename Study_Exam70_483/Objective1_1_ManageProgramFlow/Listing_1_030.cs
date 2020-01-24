using System;
using System.Collections.Concurrent;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using a ConcurrentBag
	public static class Listing_1_030
	{
		public static void Main()
		{
			ConcurrentBag<int> bag = new ConcurrentBag<int>();

			bag.Add(42);
			bag.Add(21);

			int result;
			if (bag.TryTake(out result))
				Console.WriteLine(result);

			if (bag.TryTake(out result))
				Console.WriteLine("There is a next item: {0}", result);
		}
	}
}
