using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public static class Program
    {
        private static int _flag = 0;
        private static int _value = 0;

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
