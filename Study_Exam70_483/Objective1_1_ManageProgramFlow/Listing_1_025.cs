using System;
using System.Linq;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Making a parallel query sequential
	public class Listing_1_025
	{
		public static void Main()
		{
			var numbers = Enumerable.Range(0, 20);
			var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).AsSequential();

			foreach (int i in parallelResult.Take(5))
			{
				Console.WriteLine(i);
			}
		}
	}
}
