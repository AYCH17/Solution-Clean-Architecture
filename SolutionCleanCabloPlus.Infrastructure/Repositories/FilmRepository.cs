using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.Core.Interfaces;

namespace SolutionCleanCabloPlus.Infrastructure
{
    public class FilmRepository : EfRepository<Film>, IFilmRepository
    {
        ILoueFilmRepository loueFilmRepository;
        public FilmRepository(SolutionCleanCabloPlusContext contexte, ILoueFilmRepository loueFilmRepository) : base(contexte)
        {
            this.loueFilmRepository = loueFilmRepository;
        }

        public Film GetFilmByLoueFilm(int id)
        {
            LoueFilm loue = loueFilmRepository.GetById(id);
            return _SolutionCleanCabloPlusContext.Films
                .Include(f => f.loues)
                .Where(f => f.loues.Contains(loue))
                .FirstOrDefault();
        }
    }
     
   }

