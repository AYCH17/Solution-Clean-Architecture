using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace SolutionCleanCabloPlus.Core
{
    public  class ServiceDiffusion : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; } 
        public string nom { get;  set; }
        public virtual List<Facture> factures { get;  set; } = new List<Facture>();
        public virtual  List<Compte?> comptes { get;  set; } = new List<Compte>();
        public virtual List<EstDesserviDans> estDesserviDans { get;  set; } = new List<EstDesserviDans>();
        


        public ServiceDiffusion()
        {
        }
        public ServiceDiffusion(string nom)
        {
            this.nom = nom;
        }



    }
}