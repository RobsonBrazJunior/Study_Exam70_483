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

        void Check(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }
    }
}
