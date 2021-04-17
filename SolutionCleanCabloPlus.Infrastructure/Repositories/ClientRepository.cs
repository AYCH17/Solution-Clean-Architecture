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
    public class ClientRepository : EfRepository<Client>, IClientRepository
    {
        ICompteRepository compteRepository;
        public ClientRepository(SolutionCleanCabloPlusContext contexte, ICompteRepository compteRepository) : base(contexte)
        {
            this.compteRepository = compteRepository;
        }

        public Client GetByCompteId(int id)
        {
            Compte compte = compteRepository.GetById(id);
            
            return _SolutionCleanCabloPlusContext.Clients
              .Include(c => c.comptes)
              .Where(c => c.comptes.Contains(compte))
              .FirstOrDefault(); 
        }

        public Task<Client> GetByCompteIdAsync(int id)
        {
            Compte compte =  compteRepository.GetByIdAsync(id).Result;

            return _SolutionCleanCabloPlusContext.Clients
              .Include(c => c.comptes)
              .Where(c => c.comptes.Contains(compte))
              .FirstOrDefaultAsync();
        }
    }

     
   }

