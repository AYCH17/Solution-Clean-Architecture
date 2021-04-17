using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class BranchementByLocalisation : BaseSpecification<Branchement>
    {
        public BranchementByLocalisation(string loc)
            : base(b => b.localisation == loc)
        { }

    }
}
