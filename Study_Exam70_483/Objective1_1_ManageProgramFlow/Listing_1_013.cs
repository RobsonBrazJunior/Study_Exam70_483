﻿using System;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using a TaskFactory
	public static class Listing_1_013
	{
		public static void Main()
		{
			Task<Int32[]> parent = Task.Run(() =>
			{
				var results = new Int32[3];

				TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

				tf.StartNew(() => results[0] = 0);
				tf.StartNew(() => results[1] = 1);
				tf.StartNew(() => results[2] = 2);
				return results;
			});

			var finalTask = parent.ContinueWith(
				parentTask => {
					foreach (int i in parentTask.Result)
						Console.WriteLine(i);
				});

			finalTask.Wait();
		}
	}
}
