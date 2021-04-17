using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace SolutionCleanCabloPlus.Core.Specifications
{
  public class ClientPersonneSearchSpecification : BaseSpecification<ClientPersonne>
  {
    public ClientPersonneSearchSpecification(string search, int item, int nbItem) :
      base(BuildCriteria(search))
    {
      //ApplyPaging(item, nbItem);
      ApplyOrderBy(x => x.nom);
    }

    protected static Expression<Func<ClientPersonne, bool>> BuildCriteria(string search)
    {
      Expression<Func<ClientPersonne, bool>> criteria = PredicateBuilder.True<ClientPersonne>();


      if (search != null)
      {
        foreach (string word in search.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
          criteria = PredicateBuilder.And(criteria, x => x.nom.Contains(word) || x.prénom.Contains(word));
        }
      }

      return criteria;
    }

  }
}
