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
    public class InstallationRepository : EfRepository<Installation>, IInstallationRepository
    {
        public InstallationRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }


        public IReadOnlyList<Installation> GetByTechnicienId(int id)
        {

            return _SolutionCleanCabloPlusContext.Installations
                .Include(i => i.technicien)
                .Where(i => i.technicienId == id)
                .ToList();
        }

        public Task<List<Installation>> GetByTechnicienIdAsync(int id)
        {
            return _SolutionCleanCabloPlusContext.Installations
               .Include(i => i.technicien)
                .Where(i => i.technicienId == id)
               .ToListAsync();
        }
    }
}
