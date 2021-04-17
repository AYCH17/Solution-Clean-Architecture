using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class ServiceDiffusionByNom : BaseSpecification<ServiceDiffusion>
    {
        public ServiceDiffusionByNom(string nom)
            : base(f => f.nom == nom)
        { }

    }
}
