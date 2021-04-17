using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core.Interfaces;
using SolutionCleanCabloPlus.Core.Specifications;


namespace SolutionCleanCabloPlus.Core.Services
{
    public class ClientService : IClientService
    {
        private readonly IBranchementRepository _branchementRepository;
        private readonly ICompteRepository _compteRepository;
        private readonly IClientRepository _clientRepository;

        private readonly IFilmRepository _filmRepository;
        private readonly IInstallationRepository _installationRepository;
        private readonly IEquipementRepository _equipementRepository;
        private readonly IServiceDiffusionRepository _serviceDiffusionRepository;
        private readonly IEstDesserviDansRepository _estDesserviDansRepository;
        private readonly IFactureRepository _factureRepository;
        private readonly ILoueFilmRepository _loueFilmRepository;
        private readonly IPaiementRepository _paiementRepository;
        private readonly ITerritoireRepository _territoireRepository;
        private readonly IClientEntrepriseRepository _clientEntrepriseRepository;
        private readonly IClientPersonneRepository _clientPersonneRepository;
        private readonly ITechnicienRepository _technicienRepository;
        private readonly IEmployéRCRepository _employéRCRepository;

        


        public ClientService(ITechnicienRepository _technicienRepository,
         IEmployéRCRepository _employéRCRepository,
        IBranchementRepository _branchementRepository,
         ICompteRepository _compteRepository,
         IClientRepository _clientRepository,
         IClientEntrepriseRepository _clientEntrepriseRepository,
         IClientPersonneRepository _clientPersonneRepository,

         IFilmRepository _filmRepository,
         IInstallationRepository _installationRepository,
         IEquipementRepository _equipementRepository,
         IServiceDiffusionRepository _serviceDiffusionRepository,
         IEstDesserviDansRepository _estDesserviDansRepository,
         IFactureRepository _factureRepository,
         ILoueFilmRepository _loueFilmRepository,
         IPaiementRepository _paiementRepository,
         ITerritoireRepository _territoireRepository)
        {
            this._branchementRepository = _branchementRepository;
            this._compteRepository = _compteRepository;
            this._clientRepository = _clientRepository;
            this._clientRepository = _clientRepository;
            this._clientPersonneRepository = _clientPersonneRepository;
            this._clientEntrepriseRepository = _clientEntrepriseRepository;
            this._filmRepository = _filmRepository;
            this._installationRepository = _installationRepository;
            this._equipementRepository = _equipementRepository;
            this._serviceDiffusionRepository = _serviceDiffusionRepository;
            this._estDesserviDansRepository = _estDesserviDansRepository;
            this._factureRepository = _factureRepository;
            this._loueFilmRepository = _loueFilmRepository;
            this._paiementRepository = _paiementRepository;
            this._territoireRepository = _territoireRepository;
            this._technicienRepository = _technicienRepository;
            this._employéRCRepository = _employéRCRepository;





        }




        public Branchement AddBranchement(Branchement branchement)
        {
            return _branchementRepository.Add(branchement);
        }

        public Task AddBranchementAsync(Branchement branchement)
        {
            return _branchementRepository.AddAsync(branchement);
        }

        public Client AddClient(Client client)
        {
            return _clientRepository.Add(client);
        }

        public Task AddClientAsync(Client client)
        {
            return _clientRepository.AddAsync(client);
        }

        public ClientEntreprise AddClientEntreprise(ClientEntreprise client)
        {
            return _clientEntrepriseRepository.Add(client);
        }

        public Task AddClientEntrepriseAsync(ClientEntreprise client)
        {
            return _clientEntrepriseRepository.AddAsync(client);

        }

        public ClientPersonne AddClientPersonne(ClientPersonne client)
        {
            return _clientPersonneRepository.Add(client);
        }

        public Task AddClientPersonneAsync(ClientPersonne client)
        {
            return _clientPersonneRepository.AddAsync(client);
        }

        public Compte AddCompte(Compte compte)
        {
            return _compteRepository.Add(compte);
        }

        public Task AddCompteAsync(Compte compte)
        {
            return _compteRepository.AddAsync(compte);
        }

        public EmployéRC AddEmployéRC(EmployéRC employéRC)
        {
            return _employéRCRepository.Add(employéRC);
        }

        public Equipement AddEquipement(Equipement equipement)
        {
            return _equipementRepository.Add(equipement);
        }

        public Task AddEquipementAsync(Equipement equipement)
        {
            return _equipementRepository.AddAsync(equipement);
        }

        public EstDesserviDans AddEstDesserviDans(EstDesserviDans est)
        {
            return _estDesserviDansRepository.Add(est);
        }

        public Task AddEstDesserviDansAsync(EstDesserviDans est)
        {
            return _estDesserviDansRepository.AddAsync(est);
        }

        public Facture AddFacture(Facture facture)
        {
            return _factureRepository.Add(facture);
        }

        public Task AddFactureAsync(Facture facture)
        {
            return _factureRepository.AddAsync(facture);
        }

        public Film AddFilm(Film film)
        {
            return _filmRepository.Add(film);
        }

        public Task AddFilmAsync(Film film)
        {
            return _filmRepository.AddAsync(film);
        }

        public Installation AddInstallation(Installation installation)
        {
            return _installationRepository.Add(installation);
        }

        public Task AddInstallationAsync(Installation installation)
        {
            return _installationRepository.AddAsync(installation);
        }

        public LoueFilm AddLoueFilm(LoueFilm loue)
        {
            return _loueFilmRepository.Add(loue);
        }

        public Task AddLoueFilmAsync(LoueFilm loue)
        {
            return _loueFilmRepository.AddAsync(loue);
        }

        public Paiement AddPaiement(Paiement paiement)
        {
            return _paiementRepository.Add(paiement);
        }

        public Task AddPaiementAsync(Paiement paiement)
        {
            return _paiementRepository.AddAsync(paiement);
        }

        public ServiceDiffusion AddServiceDiffusion(ServiceDiffusion serviceDiffusion)
        {
            return _serviceDiffusionRepository.Add(serviceDiffusion);
        }

        public Task AddServiceDiffusionAsync(ServiceDiffusion serviceDiffusion)
        {
            return _serviceDiffusionRepository.AddAsync(serviceDiffusion);
        }

        public Technicien AddTechnicien(Technicien technicien)
        {
            return _technicienRepository.Add(technicien);
        }

        public Territoire AddTerritoire(Territoire territoire)
        {
            return _territoireRepository.Add(territoire);
        }

        public Task AddTerritoireAsync(Territoire territoire)
        {
            return _territoireRepository.AddAsync(territoire);
        }

        public int DeleteBranchement(Branchement branchement)
        {
            return _branchementRepository.Delete(branchement);
        }

        public Task DeleteBranchementAsync(Branchement branchement)
        {
            return _branchementRepository.DeleteAsync(branchement);
        }

        public int DeleteClient(Client client)
        {
            return _clientRepository.Delete(client);
        }

        public Task DeleteClientAsync(Client client)
        {
            return _clientRepository.DeleteAsync(client);
        }

        public int DeleteCompte(Compte compte)
        {
            return _compteRepository.Delete(compte);
        }

        public Task DeleteCompteAsync(Compte compte)
        {
            return _compteRepository.DeleteAsync(compte);
        }

        public int DeleteEquipement(Equipement equipement)
        {
            return _equipementRepository.Delete(equipement);
        }

        public Task DeleteEquipementAsync(Equipement equipement)
        {
            return _equipementRepository.DeleteAsync(equipement);
        }

        public int DeleteEstDesserviDans(EstDesserviDans est)
        {
            return _estDesserviDansRepository.Delete(est);
        }

        public Task DeleteEstDesserviDansAsync(EstDesserviDans est)
        {
            return _estDesserviDansRepository.DeleteAsync(est);
        }

        public int DeleteFacture(Facture facture)
        {
            return _factureRepository.Delete(facture);
        }

        public Task DeleteFactureAsync(Facture facture)
        {
            return _factureRepository.DeleteAsync(facture);
        }

        public int DeleteFilm(Film film)
        {
            return _filmRepository.Delete(film);
        }

        public Task DeleteFilmAsync(Film film)
        {
            return _filmRepository.DeleteAsync(film);
        }

        public int DeleteInstallation(Installation installation)
        {
            return _installationRepository.Delete(installation);
        }

        public Task DeleteInstallationAsync(Installation installation)
        {
            return _installationRepository.DeleteAsync(installation);
        }

        public int DeleteServiceDiffusion(ServiceDiffusion serviceDiffusion)
        {
            return _serviceDiffusionRepository.Delete(serviceDiffusion);
        }

        public Task DeleteServiceDiffusionAsync(ServiceDiffusion serviceDiffusion)
        {
            return _serviceDiffusionRepository.DeleteAsync(serviceDiffusion);
        }

        public IReadOnlyList<Client> GetAllClients()
        {
            return _clientRepository.ListAll();
        }

        public Task<IReadOnlyList<Client>> GetAllClientsAsync()
        {
            return _clientRepository.ListAllAsync();
        }

        public IReadOnlyList<Compte> GetAllComptes()
        {
            return _compteRepository.ListAll();
        }

        public Task<IReadOnlyList<Compte>> GetAllComptesAsync()
        {
            return _compteRepository.ListAllAsync();
        }

        public IReadOnlyList<Equipement> GetAllEquipements()
        {
            return _equipementRepository.ListAll();
        }

        public Task<IReadOnlyList<Equipement>> GetAllEquipementsAsync()
        {
            return _equipementRepository.ListAllAsync();
        }

        public IReadOnlyList<Film> GetAllFilms()
        {
            return _filmRepository.ListAll();
        }

        public Task<IReadOnlyList<Film>> GetAllFilmsAsync()
        {
            return _filmRepository.ListAllAsync();
        }

        public IReadOnlyList<Installation> GetAllInstallations()
        {
            return _installationRepository.ListAll();
        }

        public IReadOnlyList<Territoire> GetAllTerritoires()
        {
            return _territoireRepository.ListAll();
        }

        public Task<IReadOnlyList<Territoire>> GetAllTerritoiresAsync()
        {
            return _territoireRepository.ListAllAsync();
        }

        public IReadOnlyList<Branchement> GetBranchementByLocalisation(string loc)
        {
            BranchementByLocalisation spec = new BranchementByLocalisation(loc);
            return _branchementRepository.List(spec);
        }

        public Task<IReadOnlyList<Branchement>> GetBranchementByLocalisationAsync(string loc)
        {
            BranchementByLocalisation spec = new BranchementByLocalisation(loc);
            return _branchementRepository.ListAsync(spec);
        }

        public Client GetClientByCompteId(int id)
        {
            return _clientRepository.GetByCompteId(id);
        }

        public Task<Client> GetClientByCompteIdAsync(int id)
        {
            return _clientRepository.GetByCompteIdAsync(id);
        }

        public Client GetClientById(int id)
        {
            return _clientRepository.GetById(id);
        }


        public Task<Client> GetClientByIdAsync(int id)
        {
            return _clientRepository.GetByIdAsync(id);
        }

        public ClientEntreprise GetClientEntrepriseById(int id)
        {
            return _clientEntrepriseRepository.GetById(id);
        }

        public ClientPersonne GetClientPersonneById(int id)
        {
            return _clientPersonneRepository.GetById(id);
        }

        public Compte GetCompteById(int id)
        {
            return _compteRepository.GetById(id);
        }

        public Task<Compte> GetCompteByIdAsync(int id)
        {
            return _compteRepository.GetByIdAsync(id);
        }

        public IReadOnlyList<Compte> GetComptesByEmployéRCId(int id)
        {
            CompteByEmployéRC spec = new CompteByEmployéRC(id);
            return _compteRepository.List(spec);
        }

        public Task<IReadOnlyList<Compte>> GetComptesByEmployéRCIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public EmployéRC GetEmployéRCByID(int id)
        {
            return _employéRCRepository.GetById(id);
        }

        public Task<EmployéRC> GetEmployéRCByIDAsync(int id)
        {
            return _employéRCRepository.GetByIdAsync(id);
        }

        public IReadOnlyList<Equipement> GetEquipementByCompteId(int id)
        {
            return _equipementRepository.GetByCompteId(id);  // modifier dans le irepo
        }

        public Task<List<Equipement>> GetEquipementByCompteIdAsync(int id)
        {
            return _equipementRepository.GetByCompteIdAsync(id);
        }

        public IReadOnlyList<Equipement> GetEquipementByFactureId(int id)
        {
            return _equipementRepository.GetByFactureId(id);
        }

        public Task<List<Equipement>> GetEquipementByFactureIdAsync(int id)
        {
            return _equipementRepository.GetByFactureIdAsync(id);
        }

        public IReadOnlyList<Equipement> GetEquipementByNom(string nom)
        {
            EquipementByNom spec = new EquipementByNom(nom);
            return _equipementRepository.List(spec);
        }

        public Task<IReadOnlyList<Equipement>> GetEquipementByNomAsync(string nom)
        {
            EquipementByNom spec = new EquipementByNom(nom);
            return _equipementRepository.ListAsync(spec);
        }

        public IReadOnlyList<EstDesserviDans> GetEstDesserviDansByTerritoireId(int id)
        {
            return _estDesserviDansRepository.GetByTerritoireId(id);
        }

        public Task<List<EstDesserviDans>> GetEstDesserviDansByTerritoireIdAsync(int id)
        {
            return _estDesserviDansRepository.GetByTerritoireIdAsync(id);
        }

        public IReadOnlyList<Facture> GetFactureByCompteId(int id)
        {
            return _factureRepository.GetByCompteId(id);
        }

        public Task<List<Facture>> GetFactureByCompteIdAsync(int id)
        {
            return _factureRepository.GetByCompteIdAsync(id);
        }

        public Facture GetFactureById(int id)
        {
            return _factureRepository.GetById(id);
        }

        public Task<Facture> GetFactureByIdAsync(int id)
        {
            return _factureRepository.GetByIdAsync(id);
        }

        public IReadOnlyList<Film> GetFilmByNom(string nom)
        {
            FilmByNom spec = new FilmByNom(nom);
            return _filmRepository.List(spec);
        }

        public Task<IReadOnlyList<Film>> GetFilmByNomAsync(string nom)
        {
            FilmByNom spec = new FilmByNom(nom);
            return _filmRepository.ListAsync(spec);
        }

        public IReadOnlyList<Installation> GetInstallationByDate(DateTime date)
        {
            InstallationByDate spec = new InstallationByDate(date);
            return _installationRepository.List(spec);
        }

        public Task<IReadOnlyList<Installation>> GetInstallationByDateAsync(DateTime date)
        {
            InstallationByDate spec = new InstallationByDate(date);
            return _installationRepository.ListAsync(spec);
        }

        public Installation GetInstallationById(int id)
        {
            return _installationRepository.GetById(id);
        }

        public IReadOnlyList<Installation> GetInstallationByTechnicienId(int id)
        {
            return _installationRepository.GetByTechnicienId(id);
        }

        public Task<List<Installation>> GetInstallationByTechnicienIdAsync(int id)
        {
            return _installationRepository.GetByTechnicienIdAsync(id);
        }

        public IReadOnlyList<LoueFilm> GetLoueFilmDuMois()
        {
            LoueFilmByDate spec = new LoueFilmByDate();
            return _loueFilmRepository.List(spec);
        }

        public Task<IReadOnlyList<LoueFilm>> GetLoueFilmDuMoisAsync()
        {
            LoueFilmByDate spec = new LoueFilmByDate();
            return _loueFilmRepository.ListAsync(spec);
        }

        public IReadOnlyList<ServiceDiffusion> GetServiceByNom(string nom)
        {
            ServiceDiffusionByNom spec = new ServiceDiffusionByNom(nom);
            return _serviceDiffusionRepository.List(spec);
        }

        public Task<IReadOnlyList<ServiceDiffusion>> GetServiceByNomAsync(string nom)
        {
            ServiceDiffusionByNom spec = new ServiceDiffusionByNom(nom);
            return _serviceDiffusionRepository.ListAsync(spec);
        }

        public IReadOnlyList<ServiceDiffusion> GetServiceDiffusionByCompteId(int id)
        {
            return _serviceDiffusionRepository.GetByCompteId(id);
        }

        public Task<List<ServiceDiffusion>> GetServiceDiffusionByCompteIdAsync(int id)
        {
            return _serviceDiffusionRepository.GetByCompteIdAsync(id);
        }

        public IReadOnlyList<ServiceDiffusion> GetServiceDiffusionByFactureId(int id)
        {
            return _serviceDiffusionRepository.GetByFactureId(id);
        }

        public Task<List<ServiceDiffusion>> GetServiceDiffusionByFactureIdAsync(int id)
        {
            return _serviceDiffusionRepository.GetByFactureIdAsync(id);
        }

        public Technicien GetTechnicienByID(int id)
        {
            return _technicienRepository.GetById(id);
        }

        public Task<Technicien> GetTechnicienByIDAsync(int id)
        {
            return _technicienRepository.GetByIdAsync(id);

        }

        public Employé GetTechnicienByTerritoireID(int id)
        {
           return  _technicienRepository.GetByTerritoireId(id);
        }

        public Territoire GetTerritoireByClientId(int id)
        {
            return _territoireRepository.GetByClientId(id);
        }

        public Task<Territoire> GetTerritoireByClientIdAsync(int id)
        {
            return _territoireRepository.GetByClientIdAsync(id);
        }

        public IReadOnlyList<Territoire> GetTerritoireByNom(string nom)
        {
            TerritoireByNom spec = new TerritoireByNom(nom);
            return _territoireRepository.List(spec);
        }

        public Task<IReadOnlyList<Territoire>> GetTerritoireByNomAsync(string nom)
        {
            TerritoireByNom spec = new TerritoireByNom(nom);
            return _territoireRepository.ListAsync(spec);
        }

       
        public int InitialiserEnvironnement()
        {

            Client client = GetClientById(1);
            if (client == null)
            {
                string[] territoires = new string[] { "Alberta", "Colombie Britannique", "Île-du-Prince-Édouard", "Manitoba", "Nouveau-Brunswick", "Nouvelle-Écosse", "Nunavut", "Ontario", "Québec", "Saskatchewan", "Terre-Neuve-et-Labrador", "Territoires-du-Nord-Ouest", "Yukon" };


                foreach (string t in territoires)
                    AddTerritoire(new Territoire(t));

                Territoire territoire = GetTerritoireByNom("Québec")[0];

                ClientPersonne client1 = AddClientPersonne(new ClientPersonne("123456789", "g5l 3x8 rimouski", territoire, "ayman", "chafni"));



                EmployéRC employérc1 = AddEmployéRC(new EmployéRC("test", "michel", "antoin", "632145789", "g5l 3x8 montréal", 20));
                Technicien technicien = new Technicien("test", "bilal", "rami", "457895123", "g5l 3x8 montréal", 24, territoire);

                AddTechnicien(technicien);
                Compte compte1 = new Compte(ModeFacturation.Annuel, client1, employérc1);
                Compte compte2 = new Compte(ModeFacturation.Mensuel, client1, employérc1);

                

                List<ServiceDiffusion> services = new List<ServiceDiffusion>();

                services.Add(AddServiceDiffusion(new ServiceDiffusion("service de base")));
                AddServiceDiffusion(new ServiceDiffusion("service maxi-vue"));
                services.Add(AddServiceDiffusion(new ServiceDiffusion("service 911")));


                compte1.serviceDiffusions = services;
                AddCompte(compte1);
                AddCompte(compte2);

                AddEquipement(new Equipement(121, "téléviseur", compte1));
                AddEquipement(new Equipement(121, "télécommande", compte1));
                AddEquipement(new Equipement(121, "décodeur", compte1));
                AddEquipement(new Equipement(121, "téléviseur XL", compte1));


                EstDesserviDans est = new EstDesserviDans(74, GetTerritoireByNom("Québec")[0], GetServiceByNom("service de base")[0]);
                EstDesserviDans est1 = new EstDesserviDans(140, GetTerritoireByNom("Québec")[0], GetServiceByNom("service maxi-vue")[0]);
                EstDesserviDans est2 = new EstDesserviDans(74, GetTerritoireByNom("Québec")[0], GetServiceByNom("service 911")[0]);

                AddEstDesserviDans(est);
                AddEstDesserviDans(est1);
                AddEstDesserviDans(est2);

                return 0;
            }

 






            return 1;



        }

        public Task InitialiserEnvironnementAsync()
        {
            Client client = GetClientByIdAsync(1).Result;

            if (client == null)
            {
                string[] territoires = new string[] { "Alberta", "Colombie Britannique", "Île-du-Prince-Édouard", "Manitoba", "Nouveau-Brunswick", "Nouvelle-Écosse", "Nunavut", "Ontario", "Québec", "Saskatchewan", "Terre-Neuve-et-Labrador", "Territoires-du-Nord-Ouest", "Yukon" };


                foreach (string t in territoires)
                    AddTerritoire(new Territoire(t));

                Territoire territoire =  GetTerritoireByNomAsync("Québec").Result[0];

                ClientPersonne client1 = new ClientPersonne("123456789", "g5l 3x8 rimouski", territoire, "ayman", "chafni");

                AddClientPersonneAsync(client1);

                EmployéRC employérc1 = new EmployéRC("test", "michel", "antoin", "632145789", "g5l 3x8 montréal", 20);
                AddEmployéRCAsync(employérc1);
                Technicien technicien = new Technicien("test", "bilal", "rami", "457895123", "g5l 3x8 montréal", 24, territoire);
                AddTechnicienAsync(technicien);
                Compte compte1 = new Compte(ModeFacturation.Annuel, client1, employérc1);
                Compte compte2 = new Compte(ModeFacturation.Mensuel, client1, employérc1);

                AddCompteAsync(compte1);
                AddCompteAsync(compte2);


            }

            return new Task(null);

        }

        public Task<Technicien> AddTechnicienAsync(Technicien technicien)
        {
            return _technicienRepository.AddAsync(technicien);
        }

        public Task<EmployéRC> AddEmployéRCAsync(EmployéRC employérc)
        {
            return _employéRCRepository.AddAsync(employérc);
        }

        public IReadOnlyList<ClientEntreprise> SearchClientEntreprises(string search, int item, int nbItem)
        {
            ClientEntrepriseSearchSpecification spec = new ClientEntrepriseSearchSpecification(search, item, nbItem);
            return _clientEntrepriseRepository.List(spec);
        }

        public Task<IReadOnlyList<ClientEntreprise>> SearchClientEntreprisesAsync(string search, int item, int nbItem)
        {
            ClientEntrepriseSearchSpecification spec = new ClientEntrepriseSearchSpecification(search, item, nbItem);
            return _clientEntrepriseRepository.ListAsync(spec);
        }

        public IReadOnlyList<ClientPersonne> SearchClientPersonnes(string search, int item, int nbItem)
        {
            ClientPersonneSearchSpecification spec = new ClientPersonneSearchSpecification(search, item, nbItem);
            return _clientPersonneRepository.List(spec);
        }

        public Task<IReadOnlyList<ClientPersonne>> SearchClientPersonnesAsync(string search, int item, int nbItem)
        {
            ClientPersonneSearchSpecification spec = new ClientPersonneSearchSpecification(search, item, nbItem);
            return _clientPersonneRepository.ListAsync(spec);
        }

        public int UpdateBranchement(Branchement branchement)
        {
            return _branchementRepository.Update(branchement);
        }

        public Task UpdateBranchementAsync(Branchement branchement)
        {
            return _branchementRepository.UpdateAsync(branchement);
        }

        public int UpdateClient(Client client)
        {
            return _clientRepository.Update(client);
        }

        public Task UpdateClientAsync(Client client)
        {
            return _clientRepository.UpdateAsync(client);
        }

        public int UpdateClientEntreprise(ClientEntreprise client)
        {
            return _clientEntrepriseRepository.Update(client);
        }

        public int UpdateClientPersonne(ClientPersonne client)
        {
            return _clientPersonneRepository.Update(client);
        }

        public int UpdateCompte(Compte compte)
        {
            return _compteRepository.Update(compte);
        }

        public Task UpdateCompteAsync(Compte compte)
        {
            return _compteRepository.UpdateAsync(compte);
        }

        public int UpdateEquipement(Equipement equipement)
        {
            return _equipementRepository.Update(equipement);
        }

        public Task UpdateEquipementAsync(Equipement equipement)
        {
            return _equipementRepository.UpdateAsync(equipement);
        }

        public int UpdateEstDesserviDans(EstDesserviDans est)
        {
            return _estDesserviDansRepository.Update(est);
        }

        public Task UpdateEstDesserviDansAsync(EstDesserviDans est)
        {
            return _estDesserviDansRepository.UpdateAsync(est);
        }

        public int UpdateFacture(Facture facture)
        {
            return _factureRepository.Update(facture);
        }

        public Task UpdateFactureAsync(Facture facture)
        {
            return _factureRepository.UpdateAsync(facture);
        }

        public int UpdateFilm(Film film)
        {
            return _filmRepository.Update(film);
        }

        public Task UpdateFilmAsync(Film film)
        {
            return _filmRepository.UpdateAsync(film);
        }

        public int UpdateInstallation(Installation installation)
        {
            return _installationRepository.Update(installation);
        }

        public Task UpdateInstallationAsync(Installation installation)
        {
            return _installationRepository.UpdateAsync(installation);
        }

        public int UpdateServiceDiffusion(ServiceDiffusion serviceDiffusion)
        {
            return _serviceDiffusionRepository.Update(serviceDiffusion);
        }

        public Task UpdateServiceDiffusionAsync(ServiceDiffusion serviceDiffusion)
        {
            return _serviceDiffusionRepository.UpdateAsync(serviceDiffusion);
        }

        public Compte GetCompteByInstallationId(int id)
        {
            return _compteRepository.GetByInstallationId(id);
        }

        public ServiceDiffusion GetServiceDiffusionByEstDesserviDans(int id)
        {
            return _serviceDiffusionRepository.GetServiceDiffusionByEstDesserviDans(id);
        }

        public IReadOnlyList<Compte> GetCompteByClientId(int id)
        {
            return _compteRepository.GetCompteByClientId(id);
        }

        public LoueFilm GetLoueFilmById(int id)
        {
            return _loueFilmRepository.GetById(id);
        }

        public Film GetFilmByLoueFilm(int id)
        {
            return _filmRepository.GetFilmByLoueFilm(id);
        }
    }
}
