using System.Threading;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Scalability versus responsiveness
	public class Listing_1_019
	{
		public static void Main() { }

		public Task SleepAsyncA(int millisecondsTimeout)
		{
			return Task.Run(() => Thread.Sleep(millisecondsTimeout));
		}

		public Task SleepAsyncB(int millisecondsTimeout)
		{
			TaskCompletionSource<bool> tcs = null;
			var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
			tcs = new TaskCompletionSource<bool>(t);
			t.Change(millisecondsTimeout, -1);
			return tcs.Task;
		}
	}
}