﻿using CallOfDuty.Models.Interfaces;

namespace CallOfDuty.Models
{
    public class Soldier : ISoldier
    {
        public Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
            => $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
    }
}
