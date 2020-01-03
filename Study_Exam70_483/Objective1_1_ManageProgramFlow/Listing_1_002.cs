using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using a background thread
	public static class Listing_1_002
	{
		public static void ThreadMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(1000);
			}
		}

		public static void Main()
		{
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			t.IsBackground = true;
			t.Start();
		}
	}
}
