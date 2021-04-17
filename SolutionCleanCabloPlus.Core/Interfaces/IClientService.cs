using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IClientService
    {
        Task AddFilmAsync(Film film);
        Film AddFilm(Film film);
        Task UpdateFilmAsync(Film film);
        int UpdateFilm(Film film);
        Task DeleteFilmAsync(Film film);
        int DeleteFilm(Film film);
        Task<IReadOnlyList<Film>> GetFilmByNomAsync(string nom);
        IReadOnlyList<Film> GetFilmByNom(string nom);

        LoueFilm GetLoueFilmById(int id);
        Film GetFilmByLoueFilm(int id);
        Task<IReadOnlyList<Film>> GetAllFilmsAsync();
        IReadOnlyList<Film> GetAllFilms();

        Installation GetInstallationById(int id);

        Task AddClientPersonneAsync(ClientPersonne client);
        ClientPersonne AddClientPersonne(ClientPersonne client);
        Task AddClientEntrepriseAsync(ClientEntreprise client);
        ClientEntreprise AddClientEntreprise(ClientEntreprise client);
        Task UpdateClientAsync(Client client);
        int UpdateClient(Client client);
        int UpdateClientPersonne(ClientPersonne client);
        int UpdateClientEntreprise(ClientEntreprise client);
        Task DeleteClientAsync(Client client);
        int DeleteClient(Client client);
        Task<Client> GetClientByIdAsync(int id);
        Client GetClientById(int id);
        ClientPersonne GetClientPersonneById(int id);
        ClientEntreprise GetClientEntrepriseById(int id);

        Task<Client> GetClientByCompteIdAsync(int id);
        Client GetClientByCompteId(int id);
        Task<IReadOnlyList<Client>> GetAllClientsAsync();
        Compte GetCompteByInstallationId(int id);
        IReadOnlyList<Client> GetAllClients();
        Task<IReadOnlyList<ClientPersonne>> SearchClientPersonnesAsync(string search, int item, int nbItem);
        IReadOnlyList<ClientPersonne> SearchClientPersonnes(string search, int item, int nbItem);
        Task<IReadOnlyList<ClientEntreprise>> SearchClientEntreprisesAsync(string search, int item, int nbItem);
        IReadOnlyList<ClientEntreprise> SearchClientEntreprises(string search, int item, int nbItem);


        EmployéRC AddEmployéRC(EmployéRC employéRC);
        Technicien AddTechnicien(Technicien technicien);
        EmployéRC GetEmployéRCByID(int id);
        Task<EmployéRC> GetEmployéRCByIDAsync(int id);

        Technicien GetTechnicienByID(int id);
        Task<Technicien> GetTechnicienByIDAsync(int id);

        Employé GetTechnicienByTerritoireID(int id);

        IReadOnlyList<Installation> GetAllInstallations();
        Task AddCompteAsync(Compte compte);
        Compte AddCompte(Compte compte);
        Task UpdateCompteAsync(Compte compte);
        int UpdateCompte(Compte compte);
        ServiceDiffusion GetServiceDiffusionByEstDesserviDans(int id);
        Task DeleteCompteAsync(Compte compte);
        int DeleteCompte(Compte compte);
        Task<Compte> GetCompteByIdAsync(int idCompte);
        Compte GetCompteById(int idCompte);
        
        Task<IReadOnlyList<Compte>> GetAllComptesAsync();
        IReadOnlyList<Compte> GetAllComptes();
        IReadOnlyList<Compte> GetComptesByEmployéRCId(int id);

        Task<IReadOnlyList<Compte>> GetComptesByEmployéRCIdAsync(int id);

        Task AddFactureAsync(Facture facture);
        Facture AddFacture(Facture facture);
        Task UpdateFactureAsync(Facture facture);
        int UpdateFacture(Facture facture);
        Task DeleteFactureAsync(Facture facture);
        int DeleteFacture(Facture facture);
        Task<List<Facture>> GetFactureByCompteIdAsync(int id);
        IReadOnlyList<Facture> GetFactureByCompteId(int id);
        Task<Facture> GetFactureByIdAsync(int id);
        Facture GetFactureById(int id);


        Task<IReadOnlyList<Territoire>> GetAllTerritoiresAsync();
        IReadOnlyList<Territoire> GetAllTerritoires();
        Task AddTerritoireAsync(Territoire territoire);
        Territoire AddTerritoire(Territoire territoire);
        Task<IReadOnlyList<Territoire>> GetTerritoireByNomAsync(string nom);
        IReadOnlyList<Territoire> GetTerritoireByNom(string nom);
        Task<Territoire> GetTerritoireByClientIdAsync(int id);
        Territoire GetTerritoireByClientId(int id);
        Task AddBranchementAsync(Branchement branchement);
        Branchement AddBranchement(Branchement branchement);
        Task UpdateBranchementAsync(Branchement branchement);
        int UpdateBranchement(Branchement branchement);
        Task DeleteBranchementAsync(Branchement branchement);
        int DeleteBranchement(Branchement branchement);
        Task<IReadOnlyList<Branchement>> GetBranchementByLocalisationAsync(string loc);
        IReadOnlyList<Branchement> GetBranchementByLocalisation(string loc);
        IReadOnlyList<Compte> GetCompteByClientId(int id);
        Task AddPaiementAsync(Paiement paiement);
        Paiement AddPaiement(Paiement paiement);
        Task AddLoueFilmAsync(LoueFilm loue);
        LoueFilm AddLoueFilm(LoueFilm loue);
        Task<IReadOnlyList<LoueFilm>> GetLoueFilmDuMoisAsync();
        IReadOnlyList<LoueFilm> GetLoueFilmDuMois();


        Task AddEstDesserviDansAsync(EstDesserviDans est);
        EstDesserviDans AddEstDesserviDans(EstDesserviDans est);
        Task UpdateEstDesserviDansAsync(EstDesserviDans est);
        int UpdateEstDesserviDans(EstDesserviDans est);
        Task DeleteEstDesserviDansAsync(EstDesserviDans est);
        int DeleteEstDesserviDans(EstDesserviDans est);
        Task<List<EstDesserviDans>> GetEstDesserviDansByTerritoireIdAsync(int id);
        IReadOnlyList<EstDesserviDans> GetEstDesserviDansByTerritoireId(int id);

        Task AddInstallationAsync(Installation installation);
        Installation AddInstallation(Installation installation);
        Task UpdateInstallationAsync(Installation installation);
        int UpdateInstallation(Installation installation);
        Task DeleteInstallationAsync(Installation installation);
        int DeleteInstallation(Installation installation);
        Task<IReadOnlyList<Installation>> GetInstallationByDateAsync(DateTime date);
        IReadOnlyList<Installation> GetInstallationByDate(DateTime date);
        Task<List<Installation>> GetInstallationByTechnicienIdAsync(int id);
        IReadOnlyList<Installation> GetInstallationByTechnicienId(int id);


        Task AddEquipementAsync(Equipement equipement);
        Equipement AddEquipement(Equipement equipement);
        Task UpdateEquipementAsync(Equipement equipement);
        int UpdateEquipement(Equipement equipement);
        Task DeleteEquipementAsync(Equipement equipement);
        int DeleteEquipement(Equipement equipement);

        Task<IReadOnlyList<Equipement>> GetAllEquipementsAsync();
        IReadOnlyList<Equipement> GetAllEquipements();

        IReadOnlyList<Equipement> GetEquipementByNom(string nom);
        Task<IReadOnlyList<Equipement>> GetEquipementByNomAsync(string nom);

        IReadOnlyList<ServiceDiffusion> GetServiceByNom(string nom);
        Task<IReadOnlyList<ServiceDiffusion>> GetServiceByNomAsync(string nom);

        Task<List<Equipement>> GetEquipementByCompteIdAsync(int id);
        IReadOnlyList<Equipement> GetEquipementByCompteId(int id);
        Task<List<Equipement>> GetEquipementByFactureIdAsync(int id);
        IReadOnlyList<Equipement> GetEquipementByFactureId(int id);

        Task AddServiceDiffusionAsync(ServiceDiffusion serviceDiffusion);
        ServiceDiffusion AddServiceDiffusion(ServiceDiffusion serviceDiffusion);
        Task UpdateServiceDiffusionAsync(ServiceDiffusion serviceDiffusion);
        int UpdateServiceDiffusion(ServiceDiffusion serviceDiffusion);
        Task DeleteServiceDiffusionAsync(ServiceDiffusion serviceDiffusion);
        int DeleteServiceDiffusion(ServiceDiffusion serviceDiffusion);
        Task<List<ServiceDiffusion>> GetServiceDiffusionByCompteIdAsync(int id);
        IReadOnlyList<ServiceDiffusion> GetServiceDiffusionByCompteId(int id);
        Task<List<ServiceDiffusion>> GetServiceDiffusionByFactureIdAsync(int id);
        IReadOnlyList<ServiceDiffusion> GetServiceDiffusionByFactureId(int id);



        Task InitialiserEnvironnementAsync();
        int InitialiserEnvironnement();

    }
}
