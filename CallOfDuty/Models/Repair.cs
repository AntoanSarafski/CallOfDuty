using CallOfDuty.Models.Interfaces;

namespace CallOfDuty.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }
        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }

        public override string ToString()
            => $"Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}
