using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  abstract class Employ� : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; }
        public string fonction { get;  set; } 
        public string mdp { get;  set; }
        public string nom { get;  set; }
        public string pr�nom { get;  set; }
        public string adresse { get;  set; }
        public string t�l�phone { get;  set; }
        public decimal salaire { get;  set; }

        public int? territoireId { get; set; }
        public Territoire territoire { get; set; }



        public Employ�()
        {
        }
        public Employ�(string fonction,string mdp, string nom, string pr�nom, string t�l�phone, string adresse, decimal salaire)
        {
            this.t�l�phone = t�l�phone;
            this.adresse = adresse;
            this.nom = nom;
            this.nom = pr�nom;
            this.Id = Id;
            this.fonction = fonction;
            this.mdp = mdp;
            this.salaire = salaire;



        }



    }
}