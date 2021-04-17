using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core
{
    public  class EmployéRC : Employé
    {
        public EmployéRC()
        {
        }
        public EmployéRC(string mdp, string nom, string prénom, string téléphone, string adresse, decimal salaire) : base("rc",mdp,nom,prénom,téléphone,adresse,salaire)
        {

           

        }



    }
}