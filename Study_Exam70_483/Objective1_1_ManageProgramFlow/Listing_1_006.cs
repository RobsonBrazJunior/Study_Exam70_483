using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using ThreadLocal<T>
	public static class Listing_1_006
	{
		public static ThreadLocal<int> _field = new ThreadLocal<int>(() => { return Thread.CurrentThread.ManagedThreadId; });

		public static void Main()
		{
			new Thread(() =>
			{
				for (int x = 0; x < _field.Value; x++)
					Console.WriteLine("Thread A: {0}", x);
			}).Start();

			new Thread(() =>
			{
				for (int x = 0; x < _field.Value; x++)
					Console.WriteLine($"Thread B: {x}");
			}).Start();

			Console.ReadKey();
		}
	}
}