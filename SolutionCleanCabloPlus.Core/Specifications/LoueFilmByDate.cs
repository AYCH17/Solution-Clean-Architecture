using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class LoueFilmByDate : BaseSpecification<LoueFilm>
    {
        public LoueFilmByDate() : base(l => l.date.CompareTo(DateTime.Today.AddMonths(-1)) >= 0 && l.date.CompareTo(DateTime.Now) <= 0)
        {
        }  
    }

}
