using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  class Technicien : Employ�
    {
        //public int Id { get;  set; }
        
        public Technicien()
        {
        }
        public Technicien(string mdp, string nom, string pr�nom, string t�l�phone, string adresse, decimal salaire, Territoire territoire) : base("t", mdp, nom,pr�nom,t�l�phone,adresse,salaire)
        {

            this.territoire = territoire;

        }



    }
}