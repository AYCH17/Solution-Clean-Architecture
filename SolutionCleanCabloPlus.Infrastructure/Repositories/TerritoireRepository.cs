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
    public class TerritoireRepository : EfRepository<Territoire>, ITerritoireRepository
    {

        IClientRepository clientRepository;
        public TerritoireRepository(SolutionCleanCabloPlusContext contexte, IClientRepository clientRepository) : base(contexte)
        {
            this.clientRepository = clientRepository;
        }

        public Territoire GetByClientId(int id)
        {
            Client client = clientRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.Territoires
                .Include(t=> t.clients)
              .Where(r => r.clients.Contains(client))
              .FirstOrDefault();
        }

        public Task<Territoire> GetByClientIdAsync(int id)
        {
            Client client = clientRepository.GetById(id);

            return _SolutionCleanCabloPlusContext.Territoires
                .Include(t => t.clients)
              .Where(r => r.clients.Contains(client))
              .FirstOrDefaultAsync();
        }
    }
}
