﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using Task.WaitAll
	public static class Listing_1_014
	{
		public static void Main()
		{
			Task[] tasks = new Task[3];

			tasks[0] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("1");
				return 1;
			});

			tasks[1] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("2");
				return 2;
			});

			tasks[2] = Task.Run(() =>
			{
				Thread.Sleep(1000);
				Console.WriteLine("3");
				return 3;
			});

			Task.WaitAll(tasks);
		}
	}
}
