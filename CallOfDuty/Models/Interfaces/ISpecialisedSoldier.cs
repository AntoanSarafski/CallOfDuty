using CallOfDuty.Enums;

namespace CallOfDuty.Models.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps corps { get; }
    }
}
