using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IServiceDiffusionRepository : IAsyncRepository<ServiceDiffusion>, IRepository<ServiceDiffusion>
    {
        Task<List<ServiceDiffusion>> GetByCompteIdAsync(int id);
        IReadOnlyList<ServiceDiffusion> GetByCompteId(int id);
        Task<List<ServiceDiffusion>> GetByFactureIdAsync(int id);
        IReadOnlyList<ServiceDiffusion> GetByFactureId(int id);
        ServiceDiffusion GetServiceDiffusionByEstDesserviDans(int id);
    }

}
