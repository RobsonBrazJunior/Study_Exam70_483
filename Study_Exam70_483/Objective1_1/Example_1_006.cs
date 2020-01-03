using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1
{
	//MultiThreading
	public class Example_1_006
	{
		public static void Main(string[] args)
		{
			Task<string> thePowerfulTaskWithReturn = Task
				.Run(() => "Junior is")
				.ContinueWith((firstResult) => firstResult.Result + " sleepy!");

			Console.WriteLine(thePowerfulTaskWithReturn.Result);
			Console.ReadLine();
		}
	}
}
