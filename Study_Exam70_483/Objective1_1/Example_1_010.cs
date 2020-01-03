using System;
using System.Linq;

namespace Study_Exam70_483.Objective1_1
{
	public class Example_1_010
	{
		public static void Main(string[] args)
		{
			var aLotOfNumbers = Enumerable.Range(0, 100);

			var parallelEvenNumbers = aLotOfNumbers
				.AsParallel()
				.Where(number => number % 2 == 0)
				.ToArray();

			foreach (var evenNumber in parallelEvenNumbers)
			{
				Console.WriteLine(evenNumber);
			}

			Console.ReadLine();
		}
	}
}