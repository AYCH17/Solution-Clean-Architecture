using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.Core.Interfaces;

namespace SolutionCleanCabloPlus.Infrastructure
{
    public class EstDesserviDansRepository : EfRepository<EstDesserviDans>, IEstDesserviDansRepository
    {
        public EstDesserviDansRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }

        public IReadOnlyList<EstDesserviDans> GetByTerritoireId(int id)
        {

            return _SolutionCleanCabloPlusContext.EstDesserviDans

                .Include(e => e.territoire)
                .Include(e=>e.serviceDiffusion)
                .Where(e => e.territoireId == id)
                .ToList();
        }

        public Task<List<EstDesserviDans>> GetByTerritoireIdAsync(int id)
        {
            return _SolutionCleanCabloPlusContext.EstDesserviDans
                .Include(e => e.territoire)
                 .Include(e => e.serviceDiffusion)

                .Where(e => e.territoireId == id)
                .ToListAsync();
        }
    }
}
