using System;
using System.Linq;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Ordered parallel query
	public static class Listing_1_024
	{
		public static void Main()
		{
			//var numbers = Enumerable.Range(0, 10);
			//var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();

			var parallelResult = Enumerable.Range(0, 10).AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();

			foreach (int i in parallelResult)
				Console.WriteLine(i);
		}
	}
}