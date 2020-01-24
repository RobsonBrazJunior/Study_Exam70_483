using System;
using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Creating a deadlock
	public class Listing_1_037
	{
		static void Main()
		{
			object lockA = new object();
			object lockB = new object();

			var up = Task.Run(() =>
			{
				lock (lockA)
				{
					Thread.Sleep(1000);
					lock (lockB)
					{
						Console.WriteLine("Locked A and B");
					}
				}
			});

			lock (lockB)
			{
				lock (lockA)
				{
					Console.WriteLine("Locekd A and B");
				}
			}

			up.Wait();
		}
	}
}
