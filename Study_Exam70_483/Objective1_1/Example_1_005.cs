using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1
{
	//Tasks
	public class Example_1_005
	{
		public static void Main(string[] args)
		{
			Task thePowerfulTask = Task.Run(() =>
			{
				for (var i = 0; i < 1000; i++)
					Console.WriteLine("for Execution nº: " + i + ", ");
			});

			thePowerfulTask.Wait();

			Task<string> thePowerfulTaskWithReturn = Task.Run(() => "sleepy!");

			Console.WriteLine("Junior is " + thePowerfulTaskWithReturn.Result);
			Console.ReadLine();
		}
	}
}
