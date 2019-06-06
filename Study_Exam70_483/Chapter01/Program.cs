using System;

namespace Chapter01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.CreateAndRaise();
        }

        public void CreateAndRaise()
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Subdcriber a called");

            p.OnChange += (sender, e) => { throw new Exception(); };

            p.OnChange += (sender, e) => Console.WriteLine("Subscriber 3 called");

            p.Raise();
        }
    }

    public class Pub
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, EventArgs.Empty);
        }
    }
}

