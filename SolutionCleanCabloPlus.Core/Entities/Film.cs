using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System.Collections.Generic;

namespace SolutionCleanCabloPlus.Core
{
    public  class Film : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; } 
        public string titre { get;  set; }
        public decimal montantLocation { get;  set; }
        public virtual List<Facture> factures { get;  set; } = new List<Facture>();
        public virtual List<LoueFilm> loues { get; set; } = new List<LoueFilm>();

        public Film()
        {
        }
        public Film(int Id, string titre, decimal montantLocation)
        {
             this.Id = Id;
            this.titre = titre;
            this.montantLocation = montantLocation;
        }



    }
}