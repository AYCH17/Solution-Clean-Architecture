using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  class Compte : BaseEntity, IAggregateRoot
    {
        
        public int Id { get;  set; }
        public ModeFacturation modeFacturation { get;  set; } 
        //public decimal totalFraisMoisAnn�e { get;  set; }
        public decimal solde { get;  set; }
        public DateTime dateCr�ation { get;  set; }
        public int clientId { get;  set; }
        public Client client { get;  set; }

        public int? employ�RCId { get;  set; } 
        public Employ�RC? employ�RC { get;  set; }
        public virtual List<ServiceDiffusion> serviceDiffusions { get;  set; } = new List<ServiceDiffusion>();
        public virtual List<Equipement> equipements { get;  set; } = new List<Equipement>();
        public virtual List<Installation> installations { get;  set; } = new List<Installation>();

        public Compte()
        {
        }
        public Compte(ModeFacturation modeFacturation,Client client, Employ�RC employ�RC )
        {
            this.dateCr�ation = DateTime.Now;
            this.modeFacturation = modeFacturation;
            this.solde = 0;
            this.client = client;
            this.employ�RC = employ�RC;
        }



    }
}