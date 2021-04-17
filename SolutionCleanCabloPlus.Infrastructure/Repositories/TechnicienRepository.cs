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
    public class TechnicienRepository : EfRepository<Technicien>, ITechnicienRepository
    {
        public TechnicienRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }

        

        public Employé GetByTerritoireId(int id)
        {
            return _SolutionCleanCabloPlusContext.Employés
                .Include(t => t.territoire)
                .Where(t => t.territoire.Id == id)
                .FirstOrDefault();
        }

        public Task<Employé> GetByTerritoireIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
     
   }

