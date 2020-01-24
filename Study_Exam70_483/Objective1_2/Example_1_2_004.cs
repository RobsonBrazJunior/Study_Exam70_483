using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2
{
	class Example_1_2_004
	{
		private static int _theFlag;
		private static volatile int _theValue;

		static void Main(string[] agrs)
		{
			TheFirstThread();
			TheSecondThread();
		}

		public static void TheFirstThread()
		{
			_theValue = 10;
			_theFlag = 1;
		}

		public static void TheSecondThread()
		{
			if (_theFlag == 1)
				Console.WriteLine(_theValue);
		}
	}
}
