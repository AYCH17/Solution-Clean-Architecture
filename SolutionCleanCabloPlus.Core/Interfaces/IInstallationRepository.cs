using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IInstallationRepository : IAsyncRepository<Installation>, IRepository<Installation>
    {
        Task<List<Installation>> GetByTechnicienIdAsync(int id);
        IReadOnlyList<Installation> GetByTechnicienId(int id);
        
    }

}
