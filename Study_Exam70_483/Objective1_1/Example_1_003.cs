using System;
using System.Threading;

namespace Study_Exam70_483.Objective1_1
{
	//ParametrizedThreadStart
	public class Example_1_003
	{
		public static void UltraCoolMethod(object o)
		{
			for (var i = 0; i < (int)o; i++)
			{
				Console.WriteLine($"Execution Thread Nº {i}");
				Thread.Sleep(0);
			}
		}

		public static void Main(string[] args)
		{
			Thread theThread = new Thread(new ParameterizedThreadStart(UltraCoolMethod));
			//You can do it implicitly as well
			//Thread theThread = new Thread(UltraCoolMethod)
			theThread.Start(10);

			theThread.Join();
		}
	}
}