using System;
using System.Collections.Generic;
using System.Text;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Core.Specifications
{
    public class FilmByNom : BaseSpecification<Film>
    {
        public FilmByNom(string nom)
            : base(f => f.titre == nom)
        { }

    }
}
