﻿using CallOfDuty.Enums;
using CallOfDuty.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, 
            string firstName,
            string lastName, 
            decimal salary,
            Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; private set; }

        public override string ToString()
            => base.ToString() + $"{Environment.NewLine}Corps: {Corps}";

    }
}
