using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_001
	{
		static void Main(string[] args)
		{
			int theAlmightyZero = 0;

			Task newAmazingTask = Task.Run(() =>
			{
				for (int i = 0; i < 1000000; i++)
					theAlmightyZero++;
			});

			for (int j = 0; j < 1000000; j++)
				theAlmightyZero--;

			newAmazingTask.Wait();

			Console.WriteLine("Here it comes a ZERO value! " + theAlmightyZero);
			Console.ReadLine();
		}
	}
}
