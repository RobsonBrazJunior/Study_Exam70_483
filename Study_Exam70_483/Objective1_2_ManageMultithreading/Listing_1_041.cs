using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Compare and exchange as a nonatomic operation
	public static class Listing_1_041
	{
		static int value = 1;

		public static void Main()
		{
			Task t1 = Task.Run(() =>
			{
				if (value == 1)
				{
					//Removing the following line will change de output
					Thread.Sleep(1000);
					value = 2;
				}
			});

			Task t2 = Task.Run(() =>
			{
				value = 3;
			});

			Task.WaitAll(t1, t2);
			Console.WriteLine(value);  //Displyas 2
		}
	}
}
