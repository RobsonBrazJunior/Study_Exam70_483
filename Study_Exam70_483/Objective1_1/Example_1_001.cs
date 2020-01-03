using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1
{
	public static class Example_1_001
    {
		public static void UltraCoolMethod()
		{
			const int iteratorNumber = 10;
			for (var i = 0; i < iteratorNumber; i++)
			{
				Console.WriteLine($"Execution Thread Nº {i}");
				Thread.Sleep(0);
			}
		}

		public static void Main(string[] args)
		{
			Thread theThread = new Thread(new ThreadStart(UltraCoolMethod));
			//You can do it implicitly as well
			//Thread theThread = new Thread(UltraCoolMethod)
			theThread.Start();

			for (var i = 0; i < 5; i++)
			{
				Console.WriteLine("Hey, the main thread is still doing stuff!");
				Thread.Sleep(0);
			}

			theThread.Join();
		}
	}
}
