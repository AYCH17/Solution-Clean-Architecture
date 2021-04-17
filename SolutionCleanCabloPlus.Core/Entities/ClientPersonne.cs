using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core
{
    public  class ClientPersonne : Client
    {
        public string nom { get;  set; } 
        public string pr�nom { get;  set; }
        
        public ClientPersonne()
        {
        }

        public ClientPersonne(Client client) : base(client.t�l�phone, client.adresse, client.territoire)
        {

        }
        public ClientPersonne(string t�l�phone, string adresse, Territoire territoire,string nom, string pr�nom) : base(t�l�phone,adresse,territoire)
        {
            this.nom = nom;
            this.pr�nom = pr�nom;
        }



    }
}