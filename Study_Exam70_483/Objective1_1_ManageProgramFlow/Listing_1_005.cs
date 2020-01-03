using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using the ThreadStaticAttribute
	public static class Listing_1_005
	{
		[ThreadStatic]
		public static int _field;
		public static void Main()
		{
			new Thread(() =>
			{
				for (int x = 0; x < 10; x++)
				{
					_field++;
					Console.WriteLine("Thread A: {0}", _field);
				}
			}).Start();

			new Thread(() =>
			{
				for (int x = 0; x < 10; x++)
				{
					_field++;
					Console.WriteLine("Thread B: {0}", _field);
				}
			}).Start();

			Console.ReadKey();
		}
	}
}
