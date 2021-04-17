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
    public class PaiementRepository : EfRepository<Paiement>, IPaiementRepository
    {
        public PaiementRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }

       
    }
     
   }

