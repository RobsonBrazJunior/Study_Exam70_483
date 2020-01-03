using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Starting a new Task
	public static class Listing_1_008
	{
		public static void Main()
		{
			Task t = Task.Run(() =>
			{
				for (var x = 0; x < 100; x++)
					Console.WriteLine("*");
			});

			t.Wait();
		}
	}
}
