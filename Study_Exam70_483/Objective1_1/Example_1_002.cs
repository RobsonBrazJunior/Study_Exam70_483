using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1
{
	//MultiThreading
	public class Example_1_002
	{
		public static void UltraCoolMethod(object o)
		{
			const int iterationNumber = 10;
			for (var i = 0; i < iterationNumber; i++)
			{
				Console.WriteLine($"Execution Thread Nº {i}");
				Thread.Sleep(0);
			}
		}

		public static void Main(string[] args)
		{
			Thread theThread = new Thread(UltraCoolMethod);
			theThread.IsBackground = true;

			theThread.Start();
		}
	}
}
