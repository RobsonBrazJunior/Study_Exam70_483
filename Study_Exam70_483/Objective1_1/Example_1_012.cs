using System;
using System.Linq;

namespace Study_Exam70_483.Objective1_1
{
	public class Example_1_012
	{
		public static void Main(string[] args)
		{
			var anIncrediblyBigSet = Enumerable.Range(0, 10);

			var parallelEvenNumbers = anIncrediblyBigSet
				.AsParallel()
				.AsOrdered() //it does not matter if it is ordered. ForAll removes any specified order.
				.Where(number => number % 2 == 0);

			parallelEvenNumbers.ForAll(even => Console.WriteLine($"Number {even}"));

			Console.ReadLine();
		}
	}
}
