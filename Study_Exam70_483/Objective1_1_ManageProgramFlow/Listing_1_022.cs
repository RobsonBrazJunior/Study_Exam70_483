using System.Linq;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using AsParallel
	public class Listing_1_022
	{
		public void UsingAsParallel()
		{
			var numbers = Enumerable.Range(0, 100000000);
			var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
		}
	}
}