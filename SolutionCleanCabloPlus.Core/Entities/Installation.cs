using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System;

namespace SolutionCleanCabloPlus.Core
{
    public  class Installation : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; } 
        public decimal frais { get;  set; }
        public DateTime dateProgramation { get;  set; }
        public DateTime dateR�alisation { get;  set; }
        public int compteId { get;  set; }
        public Compte compte { get;  set; }
        public int technicienId { get;  set; }
        public Employ� technicien { get;  set; }

        public Installation()
        {
        }
        public Installation(decimal frais, DateTime dateProgramation, DateTime dateR�alisation, Compte compte, Employ� technicien)
        {
             
            this.dateProgramation = dateProgramation;
            this.dateR�alisation = dateR�alisation;
            this.frais = frais;
            this.compte = compte;
            this.technicien = technicien;
        }



    }
}