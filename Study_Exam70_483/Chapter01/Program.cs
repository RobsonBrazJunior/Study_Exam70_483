using System;
using System.Runtime.ExceptionServices;

namespace Chapter01
{
    public static class Program
    {
        public static void Main()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException ex)
            {
                possibleException = ExceptionDispatchInfo.Capture(ex);
            }

            if (possibleException != null)
                possibleException.Throw();
        }
    }
}

