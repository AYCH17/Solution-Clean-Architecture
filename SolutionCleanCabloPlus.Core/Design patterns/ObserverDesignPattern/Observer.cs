using System;
namespace SolutionCleanCabloPlus.Core
{
    public interface Observer
    {
        void Update(object subject);
    }
}