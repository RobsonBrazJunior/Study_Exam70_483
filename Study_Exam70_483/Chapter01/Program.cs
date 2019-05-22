using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public void Process (string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            // Do something with the result
        }
    }
}
