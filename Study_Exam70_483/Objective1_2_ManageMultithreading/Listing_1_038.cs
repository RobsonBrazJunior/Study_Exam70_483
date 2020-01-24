using System.Threading;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//Generated code from a lock statement
	class Listing_1_038
	{
		static void Main()
		{
			object gate = new object();
			bool _lockTaken = false;

			try
			{
				Monitor.Enter(gate, ref _lockTaken);
			}
			finally
			{
				if (_lockTaken)
					Monitor.Exit(gate);
			}
		}
	}
}