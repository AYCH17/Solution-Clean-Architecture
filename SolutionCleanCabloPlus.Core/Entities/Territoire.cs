using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SolutionCleanCabloPlus.Core
{
    public  class Territoire : BaseEntity, IAggregateRoot
    {
        
        public int Id { get;  set; } 
        public string nom { get;  set; }
        public Employé employé { get;  set; }

        public virtual List<Client> clients { get;   set; } = new List<Client>();
        public Territoire()
        {
        }
        public Territoire(string nom)
        {
            this.nom = nom;
        }



    }
}