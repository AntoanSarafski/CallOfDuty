﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Models.Interfaces
{
    public interface IPrivate : ISoldier
    {
        public decimal Salary { get; set; }
    }
}
