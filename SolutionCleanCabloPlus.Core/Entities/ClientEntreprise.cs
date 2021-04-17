using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core
{
    public  class ClientEntreprise : Client
    {
        //public int Id { get;  set; }
        public string raisonSociale { get;  set; }

        public ClientEntreprise()
        {
            //
        }

        public ClientEntreprise(Client client) : base(client.téléphone,client.adresse,client.territoire)
        {

        }

        public ClientEntreprise(string téléphone, string adresse, Territoire territoire,string raisonSociale) : base(téléphone, adresse,territoire)
        {
           
            this.raisonSociale = raisonSociale;
        }
    }
}