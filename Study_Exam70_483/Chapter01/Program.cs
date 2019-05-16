using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public static class Program
    {
        public static void Main()
        {
            object gate = new object();
            bool __lockTaken = false;

            try
            {
                Monitor.Enter(gate, ref __lockTaken);
            }
            finally
            {
                if (__lockTaken)
                    Monitor.Exit(gate);
;            }
        }
    }
}
