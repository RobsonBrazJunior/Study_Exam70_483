using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using the ParameterizedThreadStart
	public static class Listing_1_003
	{
		public static void ThreadMethod(object o)
		{
			for (int i = 0; i < (int)o; i++)
			{
				Console.WriteLine("ThreadProc: {0}", i);

				Thread.Sleep(0);
			}
		}

		public static void Main()
		{
			Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
			t.Start(5);
			t.Join();
		}
	}
}

