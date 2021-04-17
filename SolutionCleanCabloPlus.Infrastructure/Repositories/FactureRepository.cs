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
    public class FactureRepository : EfRepository<Facture>, IFactureRepository
    {
        public FactureRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }

        public IReadOnlyList<Facture> GetByCompteId(int id)
        {
            return _SolutionCleanCabloPlusContext.Factures
                
                .Include(f => f.compte)
                .Where(f => f.compte.Id == id)
                .ToList();
        }

        public Task<List<Facture>> GetByCompteIdAsync(int id)
        {
            return _SolutionCleanCabloPlusContext.Factures
                .Include(f => f.compte)
                .Where(f => f.compte.Id == id)
                .ToListAsync();
        }

        public decimal GetMontantTotalFacturesNonPayees(int idCompte)
        {
            IReadOnlyList<Facture> factures = GetByCompteId(idCompte);
            decimal montant = 0;
            foreach(Facture f in factures)
            {
                if(f.payée == false)
                {
                    montant += f.montantEquipements + f.montantFilms + f.montantInstallation + f.montantServicesDiffusion;
                }
            }

            return montant;
        }
    }
}
