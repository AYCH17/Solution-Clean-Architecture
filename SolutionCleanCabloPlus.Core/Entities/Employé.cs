using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  abstract class Employé : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; }
        public string fonction { get;  set; } 
        public string mdp { get;  set; }
        public string nom { get;  set; }
        public string prénom { get;  set; }
        public string adresse { get;  set; }
        public string téléphone { get;  set; }
        public decimal salaire { get;  set; }

        public int? territoireId { get; set; }
        public Territoire territoire { get; set; }



        public Employé()
        {
        }
        public Employé(string fonction,string mdp, string nom, string prénom, string téléphone, string adresse, decimal salaire)
        {
            this.téléphone = téléphone;
            this.adresse = adresse;
            this.nom = nom;
            this.nom = prénom;
            this.Id = Id;
            this.fonction = fonction;
            this.mdp = mdp;
            this.salaire = salaire;



        }



    }
}