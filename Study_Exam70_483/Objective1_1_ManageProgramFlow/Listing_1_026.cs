using System;
using System.Linq;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using ForAll
	public class Listing_1_026
	{
		public static void Main()
		{
			var numbers = Enumerable.Range(0, 20);

			var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0);

			parallelResult.ForAll(e => Console.WriteLine(e));
		}

	}
}
