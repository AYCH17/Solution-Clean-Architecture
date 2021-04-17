using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;

namespace SolutionCleanCabloPlus.Core
{
    public  class ClientPersonne : Client
    {
        public string nom { get;  set; } 
        public string prénom { get;  set; }
        
        public ClientPersonne()
        {
        }

        public ClientPersonne(Client client) : base(client.téléphone, client.adresse, client.territoire)
        {

        }
        public ClientPersonne(string téléphone, string adresse, Territoire territoire,string nom, string prénom) : base(téléphone,adresse,territoire)
        {
            this.nom = nom;
            this.prénom = prénom;
        }



    }
}