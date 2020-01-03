using System;
using System.Linq;
using System.Threading;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Creating a thread with the Thread class
	public static class Listing_1_001
	{
		public static void ThreadMethod()
		{
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("ThreadProc: {0}", i);
				Thread.Sleep(0);
			}
		}

		public static void Main()
		{
			Thread t = new Thread(new ThreadStart(ThreadMethod));
			t.Start();

			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("Main thread: Do some work.");
				Thread.Sleep(0);
			}

			t.Join();
		}
	}
}