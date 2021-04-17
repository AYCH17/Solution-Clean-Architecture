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
    public class ClientEntrepriseRepository : EfRepository<ClientEntreprise>, IClientEntrepriseRepository
    {
        public ClientEntrepriseRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }

        

    }
     
   }

