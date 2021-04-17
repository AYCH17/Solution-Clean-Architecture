using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  class Technicien : Employé
    {
        //public int Id { get;  set; }
        
        public Technicien()
        {
        }
        public Technicien(string mdp, string nom, string prénom, string téléphone, string adresse, decimal salaire, Territoire territoire) : base("t", mdp, nom,prénom,téléphone,adresse,salaire)
        {

            this.territoire = territoire;

        }



    }
}