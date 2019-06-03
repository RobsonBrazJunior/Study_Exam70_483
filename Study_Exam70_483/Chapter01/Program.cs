using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter tw);

        ContravarianceDel del = DoSomething;
    }
}

