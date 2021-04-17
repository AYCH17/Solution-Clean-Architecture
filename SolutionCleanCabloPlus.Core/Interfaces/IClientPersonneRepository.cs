using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IClientPersonneRepository : IAsyncRepository<ClientPersonne>, IRepository<ClientPersonne>
    {
       
    }

}
