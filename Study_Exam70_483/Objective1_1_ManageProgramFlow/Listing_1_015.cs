using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using Task.WaitAny
	public static class Listing_1_015
	{
		public static void Main()
		{
			Task<int>[] tasks = new Task<int>[3];

			tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
			tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
			tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

			while (tasks.Length > 0)
			{
				int i = Task.WaitAny(tasks);
				Task<int> completedTask = tasks[i];

				Console.WriteLine(completedTask.Result);

				var temp = tasks.ToList();
				temp.RemoveAt(i);
				tasks = temp.ToArray();
			}
		}
	}
}
