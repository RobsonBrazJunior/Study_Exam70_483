using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Accessing shared data in a multithreaded application
	public class Listing_1_035
	{
		static void Main()
		{
			int n = 0;

			var up = Task.Run(() =>
			{
				for (int i = 0; i < 1000000; i++)
					n++;
			});

			for (int i = 0; i < 1000000; i++)
				n--;

			up.Wait();
			Console.WriteLine(n);
		}
	}
}
