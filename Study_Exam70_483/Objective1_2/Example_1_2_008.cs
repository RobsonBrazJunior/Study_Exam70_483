using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_008
	{
		static void Main(string[] args)
		{
			Task notThaPowerfulTask = Task.Run(() =>
			{
				Console.WriteLine("A long-running task is executed right now...");
				Thread.Sleep(10000);
			});

			Console.WriteLine("Well, I have only 5s...");
			int result = Task.WaitAny(new[] { notThaPowerfulTask }, 5000);

			if (result == -1)
				Console.WriteLine("I am out... It is taking too much time!");

			Console.ReadLine();
		}
	}
}
