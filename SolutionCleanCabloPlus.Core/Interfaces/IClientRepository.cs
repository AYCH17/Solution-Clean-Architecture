using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IClientRepository : IAsyncRepository<Client>, IRepository<Client>
    {
        Task<Client> GetByCompteIdAsync(int id);
        Client GetByCompteId(int id);
       
    }

}
