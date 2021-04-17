using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface ITerritoireRepository : IAsyncRepository<Territoire>, IRepository<Territoire>
    {
        
        Task<Territoire> GetByClientIdAsync(int id);
        Territoire GetByClientId(int id);

    }

}
