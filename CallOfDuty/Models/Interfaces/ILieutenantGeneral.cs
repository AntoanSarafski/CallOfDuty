using System.Collections.Generic;

namespace CallOfDuty.Models.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
         
    }
}
