using CallOfDuty.Enums;

namespace CallOfDuty.Models.Interfaces
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();
    }
}
