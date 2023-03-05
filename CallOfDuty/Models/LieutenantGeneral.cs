﻿using CallOfDuty.Models.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(
            int id, 
            string firstName,
            string lastName, 
            decimal salary,
            IReadOnlyCollection<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public IReadOnlyCollection<IPrivate> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var currentPrivate in Privates)
            {
                sb.AppendLine($"  {currentPrivate.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}