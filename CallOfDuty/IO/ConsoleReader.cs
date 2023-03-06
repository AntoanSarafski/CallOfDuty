using CallOfDuty.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.IO
{
    public class ConsoleReader : Ireader
    {
        public string ReadLine() => Console.ReadLine();
    }
}
