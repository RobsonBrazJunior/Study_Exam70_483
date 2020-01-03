using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1
{
	//MultiThreading
	public class Example_1_007
	{
		public static void Main(string[] args)
		{
			Stopwatch myStopwatch = new Stopwatch();

			Task[] aSetOfTasks = new Task[3];

			myStopwatch.Start();
			aSetOfTasks[0] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("Junior drinks coffee.");
			});

			aSetOfTasks[1] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("Junior fixes some bugs.");
			});

			aSetOfTasks[2] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("Junior... falls asleep");
			});

			Task.WaitAll(aSetOfTasks);

			myStopwatch.Stop();
			var timeStampStopWatch = myStopwatch.Elapsed;
			Console.WriteLine($"It took {timeStampStopWatch.ToString("g")}");

			Console.ReadLine();
		}
	}
}
