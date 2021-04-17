using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  class Facture : BaseEntity, IAggregateRoot
    {
        
        public int Id { get;  set; }
        public DateTime date { get;  set; } 
        public decimal montantFilms { get;  set; }
        public decimal montantEquipements { get;  set; }
        public decimal montantServicesDiffusion { get;  set; }
        public decimal montantInstallation { get;  set; }


        public bool payée { get;  set; }
        public virtual List<Equipement> equipements { get;   set; } = new List<Equipement>();
        public virtual List<ServiceDiffusion> serviceDiffusions { get;   set; } = new List<ServiceDiffusion>();
        public virtual List<Film> films { get;   set; } = new List<Film>();

        public int? compteId { get;  set; }
        public Compte compte { get;  set; }
        public int? paiementId { get;  set; }

        public Paiement paiement { get;  set; }

        public Facture()
        {
            //
        }
        public Facture(decimal montantFilms, decimal montantEquipements, decimal montantServicesDiffusion, decimal montantInstallation,Compte compte,List<Film> films)
        {
            this.date = DateTime.Now;
            this.payée = false;
            this.montantInstallation = montantInstallation;
            this.montantEquipements = montantEquipements;
            this.montantFilms = montantFilms;
            this.montantServicesDiffusion = montantServicesDiffusion;
            this.compte = compte;
            this.equipements = compte.equipements;
            this.serviceDiffusions = compte.serviceDiffusions;
            this.films = films;

        }



    }
}