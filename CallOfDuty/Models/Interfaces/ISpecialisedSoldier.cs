using CallOfDuty.Enums;

namespace CallOfDuty.Models.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
