using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class InstallationByDate : BaseSpecification<Installation>
    {
        public InstallationByDate(DateTime fin) : base(p => p.dateProgramation.CompareTo(DateTime.Now) >= 0 && p.dateProgramation.CompareTo(fin.Date) <= 0)
        {
        }  
    }

}
