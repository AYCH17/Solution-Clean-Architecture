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
    public class CompteRepository : EfRepository<Compte>, ICompteRepository
    {

        IInstallationRepository installationRepository;
        public CompteRepository(SolutionCleanCabloPlusContext contexte, IInstallationRepository installationRepository) : base(contexte)
        {
            this.installationRepository = installationRepository;
        }

       

        public Compte GetByInstallationId(int id)
        {
            Installation installation = installationRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.Comptes
              .Include(c => c.installations)
              .Where(c => c.installations.Contains(installation))
              .FirstOrDefault();

        }

        public Task<Compte> GetByInstallationIdAsync(int id)
        {
            Installation installation = installationRepository.GetByIdAsync(id).Result;

            return _SolutionCleanCabloPlusContext.Comptes
              .Include(c => c.installations)
              .Where(c => c.installations.Contains(installation))
              .FirstOrDefaultAsync();
        }

        public IReadOnlyList<Compte> GetCompteByClientId(int id)
        {
            return _SolutionCleanCabloPlusContext.Comptes
                .Include(c => c.client)
                .Where(c => c.clientId == id)
                .ToList();
        }

       
    }
}
