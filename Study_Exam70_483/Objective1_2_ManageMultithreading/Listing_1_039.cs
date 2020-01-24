using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Exam70_483.Objective1_2_ManageMultithreading
{
	//A potential problem with multithreaded code
	class Listing_1_039
	{
		private static volatile int _flag = 0;
		private static volatile int _value = 0;

		static void Main()
		{
		}

		public static void Thread1()
		{
			_value = 5;
			_flag = 1;
		}

		public static void Thread2()
		{
			if (_flag == 1)
				Console.WriteLine(_value);
		}
	}
}
