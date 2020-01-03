using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Adding a continuation
	public static class Listing_1_010
	{
		public static void Main()
		{
			Task<int> t = Task.Run(() =>
			{
				return 42;
			}).ContinueWith((i) =>
			{
				return i.Result * 2;
			});

			Console.WriteLine(t.Result); //Displays 84
		}
	}
}