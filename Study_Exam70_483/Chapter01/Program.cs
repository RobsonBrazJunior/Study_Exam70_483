using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public void Main()
        {
            bool b = true;
            if (b)
            {
                int r = 42; // r is not accessible out side code block
                b = false;
            }
        }
    }
}
