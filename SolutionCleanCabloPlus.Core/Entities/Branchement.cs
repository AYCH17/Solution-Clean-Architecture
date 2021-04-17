using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core
{
    public  class Branchement : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; }
        public string localisation { get;  set; } 

        public int? compteId { get;  set; }
        public Compte compte { get;  set; }
        public int installationId { get;  set; }
        public Installation installation { get;  set; }
        public Branchement()
        {
        }
        public Branchement(string localisation, Compte compte, Installation installation)
        {
            this.Id = Id; 
            this.localisation = localisation;
            this.compte = compte;
            this.installation = installation;
        }



    }
}