using CallOfDuty.Core;
using CallOfDuty.Core.Interfaces;
using System;

namespace CallOfDuty
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
