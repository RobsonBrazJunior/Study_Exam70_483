using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public static void Main()
        {
            Person pessoa = new Person();
            pessoa.CannotChangeForeachIterationVariable();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person() {FirstName = "John", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"}
            };

            foreach (Person p in people)
            {
                p.LastName = "Changed"; // This is allowed
                Console.WriteLine(p.FirstName + " " + p.LastName);
                // p = new Person();  //This gives a compile error
            }
        }
    }    
}

