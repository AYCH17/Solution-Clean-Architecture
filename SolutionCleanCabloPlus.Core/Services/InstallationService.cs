using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core.Interfaces;

namespace SolutionCleanCabloPlus.Core.Services
{
    public class InstallationService : IInstallationService

    {
        private readonly IClientService clientService;

        public InstallationService(IClientService _)
        {
            clientService = _;
        }
        public bool AdresseBranchée(string localisation)
        {
            IReadOnlyList<Branchement> br = clientService.GetBranchementByLocalisation(localisation);
            
            if (br.Equals(null))
                return false;
            else
                return true;
        }

        public async Task<bool> AdresseBranchéeAsync(string localisation)
        {
            IReadOnlyList<Branchement> br = clientService.GetBranchementByLocalisationAsync(localisation).Result;

            if (br == null)
                return false;
            else
                return true;
        }
    }
}
