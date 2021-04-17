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
    public class LoueFilmRepository : EfRepository<LoueFilm>, ILoueFilmRepository
    {
        public LoueFilmRepository(SolutionCleanCabloPlusContext contexte) : base(contexte)
        {
        }

        

    }
     
   }

