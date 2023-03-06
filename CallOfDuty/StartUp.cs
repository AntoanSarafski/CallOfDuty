using CallOfDuty.Core;
using CallOfDuty.Core.Interfaces;
using CallOfDuty.IO;
using System;

namespace CallOfDuty
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine(
                new ConsoleReader(),
                new ConsoleWriter()
                );
            engine.Run();
        }
    }
}
