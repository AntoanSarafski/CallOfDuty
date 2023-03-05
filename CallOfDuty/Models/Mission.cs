using CallOfDuty.Enums;
using CallOfDuty.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Models
{
    public class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            State = State.Finished;
        }

        public override string ToString()
            => $"Code Name: {this.CodeName} State: {this.State}";
    }
}
