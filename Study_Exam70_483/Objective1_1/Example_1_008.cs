using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1
{
	//MultiThreading
	public class Example_1_008
	{
		public static void Main()
		{
			Console.WriteLine("Printing Even numbers using Parallel.For");
			Parallel.For(0, 10, i =>
			{
				if (i % 2 == 0)
					Console.WriteLine(i);

				Thread.Sleep(1000);
			});

			Console.WriteLine("Printing Even numbers using Parallel.ForEach");
			var fromOneToTen = Enumerable.Range(0, 10);
			Parallel.ForEach(fromOneToTen, i =>
			{
				if (i % 2 == 0)
					Console.WriteLine(i);

				Thread.Sleep(1000);
			});

			Console.ReadLine();
		}
	}
}

