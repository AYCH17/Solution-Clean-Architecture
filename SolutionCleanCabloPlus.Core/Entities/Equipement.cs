using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace SolutionCleanCabloPlus.Core
{
    public  class Equipement : BaseEntity, IAggregateRoot
    {
        public int Id { get; private set; } 
        public decimal tarifMensuelLocation { get; private set; }
        public string nom { get; private set; }
        public int? compteId { get; private set; }
        public Compte compte { get; private set; }
        public virtual List<Facture> factures { get; private set; } = new List<Facture>();


        public Equipement()
        {
        }
        public Equipement(decimal tarifMensuelLocation, string nom,Compte compte)
        {
            this.tarifMensuelLocation = tarifMensuelLocation;
            this.nom = nom;
            this.compte = compte;
        }



    }
}