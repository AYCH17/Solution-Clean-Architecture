using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IFactureRepository : IAsyncRepository<Facture>, IRepository<Facture>
    {
        Task<List<Facture>> GetByCompteIdAsync(int id);
        IReadOnlyList<Facture> GetByCompteId(int id);

        decimal GetMontantTotalFacturesNonPayees(int idCompte);
        
    }

}
