using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_002
	{
		static void Main(string[] args)
		{
			int theAlmightyZero = 0;
			object _lockTheSavior = new object();

			Task newAmazingTask = Task.Run(() =>
			{
				for (int i = 0; i < 1000000; i++)
					lock (_lockTheSavior)
						theAlmightyZero++;
			});

			for (int j = 0; j < 1000000; j++)
				lock (_lockTheSavior)
					theAlmightyZero--;

			newAmazingTask.Wait();

			Console.WriteLine("Here it comes a ZERO value (now that is true)! " + theAlmightyZero);
		}
	}
}