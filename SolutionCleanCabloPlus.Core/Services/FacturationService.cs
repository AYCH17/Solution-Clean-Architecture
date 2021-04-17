using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core.Interfaces;

namespace SolutionCleanCabloPlus.Core.Services
{
    public class FacturationService : IFacturationService
    {
        private readonly IClientService _clientService;
        private readonly IFactureRepository _factureRepository;

        public FacturationService(IClientService clientRepository, IFactureRepository factureRepository)
        {
            _factureRepository = factureRepository;
            _clientService = clientRepository;
        }

        public void AddFacture(Compte compte, Installation installation)
        {
            decimal montantEquipements = 0; 
            decimal montantServicesDiffusion = 0;
            decimal montantFilms = 0;

            foreach (Equipement e in compte.equipements)
            {
                montantEquipements += e.tarifMensuelLocation;
            }

            Client client = _clientService.GetClientByCompteId(compte.Id);
            Territoire territoire = _clientService.GetTerritoireByClientId(client.Id);
            IReadOnlyList<EstDesserviDans> est = _clientService.GetEstDesserviDansByTerritoireId(territoire.Id);
            foreach (EstDesserviDans e in est)
            {
                foreach (ServiceDiffusion s in compte.serviceDiffusions)
                {
                    if (s == e.serviceDiffusion)
                    {
                        montantServicesDiffusion += e.tarif;
                    }
                }
            }
                IReadOnlyList<LoueFilm> loues = _clientService.GetLoueFilmDuMois();
                List<Film> filmsVus = new List<Film>();

                Film film;
                foreach (LoueFilm l in loues)
                {
                    film = _clientService.GetFilmByLoueFilm(l.Id);
                    montantFilms += film.montantLocation;
                    filmsVus.Add(film);
                }


                Facture facture;

                if (installation == null)
                    facture = new Facture(montantFilms, montantEquipements, montantServicesDiffusion, 0, compte, filmsVus);
                else
                    facture = new Facture(montantFilms, montantEquipements, montantServicesDiffusion, installation.frais, compte, filmsVus);


                
            
            _clientService.AddFacture(facture);

        }

        public async Task AddFactureAsync(Compte compte, Installation installation)
        {

            decimal montantEquipements = 0;
            decimal montantServicesDiffusion = 0;
            decimal montantFilms = 0;

            foreach (Equipement e in compte.equipements)
            {
                 montantEquipements += e.tarifMensuelLocation;
            }

            Client client =  _clientService.GetClientByCompteIdAsync(compte.Id).Result;
            Territoire territoire = _clientService.GetTerritoireByClientIdAsync(client.Id).Result;
            IReadOnlyList<EstDesserviDans> est = _clientService.GetEstDesserviDansByTerritoireIdAsync(territoire.Id).Result;
            foreach (EstDesserviDans e in est)
            {
                foreach (ServiceDiffusion s in compte.serviceDiffusions)
                {
                    if (s == e.serviceDiffusion)
                    {
                        montantServicesDiffusion += e.tarif;
                    }
                }

                IReadOnlyList<LoueFilm> loues = _clientService.GetLoueFilmDuMoisAsync().Result;
                List<Film> filmsVus = new List<Film>();

                foreach (LoueFilm l in loues)
                {
                    montantFilms += l.film.montantLocation;
                    filmsVus.Add(l.film);
                }


                Facture facture;
                    
                if(installation == null)   
                        facture = new Facture(montantFilms, montantEquipements,montantServicesDiffusion,0, compte, filmsVus);
                else
                    facture = new Facture(montantFilms, montantEquipements, montantServicesDiffusion, installation.frais, compte, filmsVus);



                await _clientService.AddFactureAsync(facture);

            }
      
        }

        public decimal CalculerMontantFacturesNonPayees(int idCompte)
        {
            return _factureRepository.GetMontantTotalFacturesNonPayees(idCompte);
        }

        public async Task FacturerComptesAsync()
        {
            IReadOnlyList<Compte> comptes = _clientService.GetAllComptesAsync().Result;
            
            foreach (Compte c in comptes)

            {
                if((DateTime.Now - c.dateCréation).TotalDays % 30 == 0)
                              await AddFactureAsync(c,null);

            }

        }

       
    }
}
