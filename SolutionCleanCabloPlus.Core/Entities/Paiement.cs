using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System;

namespace SolutionCleanCabloPlus.Core
{
    public  class Paiement : BaseEntity , IAggregateRoot
    {
        public int Id { get;  set; } 
        public decimal montant { get;  set; }
        public DateTime date { get;  set; }
        public int? compteId { get;  set; }
        public Compte compte { get;  set; }
        public Facture facture { get;  set; }


        public Paiement()
        {
        }
        public Paiement(decimal montant, DateTime date ,Compte compte,Facture facture)
        {
            this.montant = montant;
            this.date = date;
            this.compte = compte;
            this.facture = facture;
        }



    }
}