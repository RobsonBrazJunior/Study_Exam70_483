using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }

        private bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }
    }
}
