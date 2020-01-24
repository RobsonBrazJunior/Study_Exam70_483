using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using GetConsumingEnumerable on a BlockingCollection
	public static class Listing_1_029
	{
		public static void Main()
		{
			BlockingCollection<string> col = new BlockingCollection<string>();
			Task read = Task.Run(() =>
			{
				foreach (string v in col.GetConsumingEnumerable())
					Console.WriteLine(v);
			});

			Task write = Task.Run(() =>
			{
				while (true)
				{
					string s = Console.ReadLine();
					if (string.IsNullOrWhiteSpace(s)) break;
					col.Add(s);
				}
			});

			write.Wait();
		}
	}
}
