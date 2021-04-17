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
    public class EquipementRepository : EfRepository<Equipement>, IEquipementRepository
    {
        IFactureRepository factureRepository;
        public EquipementRepository(SolutionCleanCabloPlusContext contexte, IFactureRepository factureRepository) : base(contexte)
        {
            this.factureRepository = factureRepository;
        }

        public IReadOnlyList<Equipement> GetByCompteId(int id)
        {

            return _SolutionCleanCabloPlusContext.Equipements
              .Include(e => e.compte)
              .Where(e => e.compte.Id == id)
              .ToList();
        }                           

        public Task<List<Equipement>> GetByCompteIdAsync(int id)
        {

            return _SolutionCleanCabloPlusContext.Equipements
              .Include(e => e.compte)
              .Where(e => e.compte.Id == id)
              .ToListAsync();
        }

        public IReadOnlyList<Equipement> GetByFactureId(int id)
        {
            Facture facture = factureRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.Equipements
                .Include(e => e.factures)
              .Where(r => r.factures.Contains(facture))
              .ToList();
        }

        public Task<List<Equipement>> GetByFactureIdAsync(int id)
        {
            Facture facture = factureRepository.GetByIdAsync(id).Result;

            return _SolutionCleanCabloPlusContext.Equipements
                .Include(e => e.factures)
             .Where(r => r.factures.Contains(facture))
             .ToListAsync();
        }
    }
}
