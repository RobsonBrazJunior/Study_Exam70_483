using System;
using System.IO;

namespace Chapter01
{
    public static class Program
    {
        public static void Main()
        {
            //string s = Console.ReadLine();

            //try
            //{
            //    int i = ReadAndParse();
            //    Console.WriteLine("Parsed: {0}", i);
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Message: {0}", e.Message);
            //    Console.WriteLine("StackTrace: {0}", e.StackTrace);
            //    Console.WriteLine("HelpLink: {0}", e.HelpLink);
            //    Console.WriteLine("InnerException: {0}", e.InnerException);
            //    Console.WriteLine("TargetSite: {0}", e.TargetSite);
            //    Console.WriteLine("Source: {0}", e.Source);
            //}
        }

        private static string OpendAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
                throw new ArgumentNullException("fileName", "Filename is required");

            return File.ReadAllText(fileName);
        }
    }
}

