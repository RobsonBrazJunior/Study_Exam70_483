using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_005
	{
		static void Main(string[] args)
		{
			int theAlmightyZero = 0;
			object _lockTheSavior = new object();

			Task newAmazingTask = Task.Run(() =>
			{
				for (int i = 0; i < 1000000; i++)
					Interlocked.Increment(ref theAlmightyZero);
			});

			for (int j = 0; j < 1000000; j++)
				Interlocked.Decrement(ref theAlmightyZero);

			newAmazingTask.Wait();

			Console.WriteLine("Here it comes a ZERO value (that is STILL true)! " + theAlmightyZero);
			Console.ReadLine();
		}
	}
}
