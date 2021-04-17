using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class EquipementByNom : BaseSpecification<Equipement>
    {
        public EquipementByNom(string nom)
            : base(f => f.nom == nom)
        { }

    }
}
