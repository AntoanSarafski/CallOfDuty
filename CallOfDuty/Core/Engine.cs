using CallOfDuty.Core.Interfaces;
using CallOfDuty.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Core
{
    public class Engine : IEngine
    {
        private Dictionary<int, ISoldier> soldiers;

        public Engine()
        {
            soldiers = new Dictionary<int, ISoldier>();
        }
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine().ToUpper()) != "END")
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(ProcessInput(tokens));
            }
        }

        private string ProcessInput(string[] tokens)
        {

        }
    }
}
