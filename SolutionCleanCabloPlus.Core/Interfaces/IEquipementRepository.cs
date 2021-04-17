using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IEquipementRepository : IAsyncRepository<Equipement>, IRepository<Equipement>
    {
        Task<List<Equipement>> GetByCompteIdAsync(int id);
        IReadOnlyList<Equipement> GetByCompteId(int id);
        Task<List<Equipement>> GetByFactureIdAsync(int id);
        IReadOnlyList<Equipement> GetByFactureId(int id);
    }

}
