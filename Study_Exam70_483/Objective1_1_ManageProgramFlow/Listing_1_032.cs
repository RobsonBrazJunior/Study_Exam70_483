using System;
using System.Collections.Concurrent;

namespace Study_Exam70_483.Objective1_1_ManageProgramFlow
{
	//Using a ConcurrentStack
	public static class Listing_1_032
	{
		public static void Main()
		{
			ConcurrentStack<int> stack = new ConcurrentStack<int>();

			stack.Push(42);

			int result;
			if (stack.TryPop(out result))
				//Console.WriteLine(("Popped: {0}", result)); === Ao utilizar dois pares de parenteses, ele apresenta o contexto explicitamente exceto o valor de variável
				Console.WriteLine("Popped: {0}", result);

			stack.PushRange(new int[] { 1, 2, 3 });

			int[] values = new int[2];
			stack.TryPopRange(values);

			foreach (int i in values)
				Console.WriteLine(i);
		}
	}
}
