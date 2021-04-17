using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface ICompteRepository : IAsyncRepository<Compte>, IRepository<Compte>
    {
        
        Task<Compte> GetByInstallationIdAsync(int id);
        Compte GetByInstallationId(int id);
        IReadOnlyList<Compte> GetCompteByClientId(int id);
    }

}
