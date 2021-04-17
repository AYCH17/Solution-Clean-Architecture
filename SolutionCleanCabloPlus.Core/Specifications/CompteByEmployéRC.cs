using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class CompteByEmployéRC : BaseSpecification<Compte>
    {
        public CompteByEmployéRC(int id)
            : base(c => c.employéRC.Id == id)
        { }

    }
}
