using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface ITechnicienRepository : IAsyncRepository<Technicien>, IRepository<Technicien>
    {
        Task<Employé> GetByTerritoireIdAsync(int id);
        Employé GetByTerritoireId(int id);
    }

}
