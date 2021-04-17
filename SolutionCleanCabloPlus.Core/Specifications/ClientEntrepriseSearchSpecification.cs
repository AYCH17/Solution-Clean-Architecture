using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace SolutionCleanCabloPlus.Core.Specifications
{
  public class ClientEntrepriseSearchSpecification : BaseSpecification<ClientEntreprise>
  {
    public ClientEntrepriseSearchSpecification(string search, int item, int nbItem) :
      base(BuildCriteria(search))
    {
      //ApplyPaging(item, nbItem);
      ApplyOrderBy(x => x.raisonSociale);
    }

    protected static Expression<Func<ClientEntreprise, bool>> BuildCriteria(string search)
    {
      Expression<Func<ClientEntreprise, bool>> criteria = PredicateBuilder.True<ClientEntreprise>();


      if (search != null)
      {
        foreach (string word in search.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
          criteria = PredicateBuilder.And<ClientEntreprise>(criteria, x => x.raisonSociale.Contains(word));
        }
      }

      return criteria;
    }

  }
}
