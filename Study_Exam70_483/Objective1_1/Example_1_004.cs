using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1
{
	//UsingThreadPools
	public class Example_1_004
	{
		public static void Main(string[] args)
		{
			ThreadPool.QueueUserWorkItem((work) =>
			{
				Console.WriteLine("Junior is trying to do something here...");
			});

			Console.ReadLine();
		}
	}
}
