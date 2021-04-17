using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class TerritoireByNom : BaseSpecification<Territoire>
    {
        public TerritoireByNom(string nom)
            : base(t => t.nom == nom)
        { }

    }
}
