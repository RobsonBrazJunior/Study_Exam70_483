using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_003
	{
		static void Main(string[] args)
		{
			object _lockSaviorOne = new object();
			object _lockSaviorTwo = new object();

			Task leTask = Task.Run(() =>
			{
				lock (_lockSaviorOne)
				{
					Thread.Sleep(1000);
					lock (_lockSaviorTwo)
						Console.WriteLine("Hey, One and Two are already locked!");
				}
			});

			Task leSecondTask = Task.Run(() =>
			{
				lock (_lockSaviorTwo)
					lock (_lockSaviorOne)
						Console.WriteLine("Yeah, One and Two are locked!");
			});

			Task.WaitAll(leTask, leSecondTask);

			Console.ReadLine();
		}
	}
}
