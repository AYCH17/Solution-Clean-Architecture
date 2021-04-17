using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IEstDesserviDansRepository : IAsyncRepository<EstDesserviDans>, IRepository<EstDesserviDans>
    {
        Task<List<EstDesserviDans>> GetByTerritoireIdAsync(int id);
        IReadOnlyList<EstDesserviDans> GetByTerritoireId(int id);

    }
}
