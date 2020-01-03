using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using Parallel.For and Parallel.Foreach
	public static class Listing_1_016
	{
		public static void Main()
		{
			Parallel.For(0, 10, i =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("For");
			});

			var numbers = Enumerable.Range(0, 10);
			Parallel.ForEach(numbers, i =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("ForEach");
			});
		}
	}
}
