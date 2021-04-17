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

        public ClientEntreprise(Client client) : base(client.t�l�phone,client.adresse,client.territoire)
        {

        }

        public ClientEntreprise(string t�l�phone, string adresse, Territoire territoire,string raisonSociale) : base(t�l�phone, adresse,territoire)
        {
           
            this.raisonSociale = raisonSociale;
        }
    }
}