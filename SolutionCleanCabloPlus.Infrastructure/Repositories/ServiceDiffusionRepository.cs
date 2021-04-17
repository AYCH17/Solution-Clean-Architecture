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
    public class ServiceDiffusionRepository : EfRepository<ServiceDiffusion>, IServiceDiffusionRepository
    {
        ICompteRepository compteRepository;
        IFactureRepository factureRepository;
        IEstDesserviDansRepository estDesserviDansRepository;
        public ServiceDiffusionRepository(SolutionCleanCabloPlusContext contexte, ICompteRepository compteRepository, IFactureRepository factureRepository, IEstDesserviDansRepository estDesserviDansRepository) : base(contexte)
        {
            this.compteRepository = compteRepository;
            this.factureRepository = factureRepository;
            this.estDesserviDansRepository = estDesserviDansRepository;
        }

        public IReadOnlyList<ServiceDiffusion> GetByCompteId(int id)
        {
            Compte compte = compteRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.ServiceDiffusions
                .Include(s=>s.comptes)
              .Where(r => r.comptes.Contains(compte))
              .ToList();
        }

        public Task<List<ServiceDiffusion>> GetByCompteIdAsync(int id)
        {
            Compte compte = compteRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.ServiceDiffusions
                .Include(s => s.comptes)
              .Where(r => r.comptes.Contains(compte))
              .ToListAsync();
        }

        public IReadOnlyList<ServiceDiffusion> GetByFactureId(int id)
        {
            Facture facture = factureRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.ServiceDiffusions
                .Include(s => s.factures)
              .Where(r => r.factures.Contains(facture))
              .ToList();
        }

        public Task<List<ServiceDiffusion>> GetByFactureIdAsync(int id)
        {
            Facture facture = factureRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.ServiceDiffusions
               .Include(s => s.factures)
              .Where(r => r.factures.Contains(facture))
              .ToListAsync();
        }

        public ServiceDiffusion GetServiceDiffusionByEstDesserviDans(int id)
        {
            EstDesserviDans est = estDesserviDansRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.ServiceDiffusions
              .Include(s => s.estDesserviDans)
              .Where(r => r.estDesserviDans.Contains(est))
              .FirstOrDefault();
        }
    }
}
