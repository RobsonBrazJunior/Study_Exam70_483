﻿using System;

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

            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);
        }
    }

    public class MyArgs : EventArgs
    {
        public int Value { get; set; }

        public MyArgs(int value)
        {
            Value = value;
        }
    }

    public class Pub
    {
        private event EventHandler<MyArgs> onChange = delegate { };
        public event EventHandler<MyArgs> OnChange
        {
            add
            {
                lock (onChange)
                {
                    onChange += value;
                }
            }
            remove
            {
                lock (onChange)
                {
                    onChange -= value;
                }
            }
        }

        public void Raise()
        {
            onChange(this, new MyArgs(42));
        }
    }
}

