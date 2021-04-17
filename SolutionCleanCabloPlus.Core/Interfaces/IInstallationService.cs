using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IInstallationService
    {
        public Task<bool> AdresseBranchéeAsync(string localisation);
        public bool AdresseBranchée(string localisation);

    }
}
