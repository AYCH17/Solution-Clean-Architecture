using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using System;

namespace SolutionCleanCabloPlus.Core
{
    public  class LoueFilm : BaseEntity, IAggregateRoot
    {
        public int Id { get;  set; } 
        public DateTime date { get;  set; }
        public int? compteId { get;  set; }
        public Compte compte { get;  set; }
        public int filmId { get;  set; }
        public Film  film { get;  set; }

        public LoueFilm()
        {
        }
        public LoueFilm(DateTime date, Compte compte, Film film)
        {
            this.date = date;
            this.compte = compte;
            this.film = film;

        }



    }
}