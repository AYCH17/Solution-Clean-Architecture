using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace SolutionCleanCabloPlus.Core
{
    public  abstract class Client : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; }
        public string t�l�phone { get;  set; } 
        public string adresse { get;  set; }
        public int territoireId { get;  set; }
        public Territoire territoire { get;  set; }
        public virtual List<Compte> comptes { get;  set; }
        public Client()
        {
            //
        }
        public Client(string t�l�phone, string adresse, Territoire territoire)
        {
            this.Id = Id;
             this.t�l�phone = t�l�phone;
            this.adresse = adresse;
            this.territoire = territoire;
        }



    }
}