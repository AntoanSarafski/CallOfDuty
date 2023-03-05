using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Models.Interfaces
{
    public interface ISoldier
    {
        public int Id { get; }

        public string FirstName { get; }

        public int LastName { get; }

    }
}
