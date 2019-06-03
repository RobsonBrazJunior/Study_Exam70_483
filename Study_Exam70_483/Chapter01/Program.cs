using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter01
{
    public class Program
    {
        public delegate TextWriter CovarianceDel();

        public StreamWriter MethodStream() { return null; }
        public StringWriter MethodString() { return null; }

        CovarianceDel del;
        del = MethodStream;
        del = MethodString;
    }
}

