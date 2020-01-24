using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Using the interlocked class
	public class Listing_1_040
	{
		static void Main()
		{
			int n = 0;

			var up = Task.Run(() =>
			{
				for (int i = 0; i < 1000000; i++)
					Interlocked.Increment(ref n);
			});

			for (int i = 0; i < 1000000; i++)
				Interlocked.Decrement(ref n);

			up.Wait();
			Console.WriteLine(n);
		}
	}
}
