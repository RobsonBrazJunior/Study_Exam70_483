using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {           
        }

        private static int GetValue(bool p)
        {
            if (p)
                return 1;
            else
                return 0;

            return p ? 1 : 0;
        }
    }
}
