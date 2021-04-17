using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IFacturationService
    {
        public Task FacturerComptesAsync();
        public Task AddFactureAsync(Compte compte, Installation installation);
        public void AddFacture(Compte compte, Installation installation);
        public decimal CalculerMontantFacturesNonPayees(int idCompte);



    }
}
