using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace SolutionCleanCabloPlus.Core
{
    public  abstract class Client : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; }
        public string téléphone { get;  set; } 
        public string adresse { get;  set; }
        public int territoireId { get;  set; }
        public Territoire territoire { get;  set; }
        public virtual List<Compte> comptes { get;  set; }
        public Client()
        {
            //
        }
        public Client(string téléphone, string adresse, Territoire territoire)
        {
            this.Id = Id;
             this.téléphone = téléphone;
            this.adresse = adresse;
            this.territoire = territoire;
        }



    }
}