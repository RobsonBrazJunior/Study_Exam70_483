using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using a Task that returns a value
	public static class Listing_1_009
	{
		public static void Main()
		{
			Task<int> t = Task.Run(() =>
			{
				return 42;
			});

			Console.WriteLine(t.Result); //Displays 42
		}
	}
}
