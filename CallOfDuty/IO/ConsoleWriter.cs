using CallOfDuty.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.IO
{
    class ConsoleWriter : IWriter
    {
        public void WriteLine(string line) => Console.WriteLine(line);
    }
}
