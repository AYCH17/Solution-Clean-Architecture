using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace SolutionCleanCabloPlus.Core.Interfaces
{
    public interface IEmployéService
    {
        Task AddEmployéAsync(Employé employé);
        Employé AddEmployé(Employé employé);
        Task UpdateEmployéAsync(Employé employé);
        int UpdateEmployé(Employé employé);
        Task DeleteEmployéAsync(Employé employé);
        int DeleteEmployé(Employé employé);
        Task<Technicien> GetTechnicienByIdAsync(int id);
        Technicien GetTechnicienById(int id);
        Task<Employé> GetTechnicienByTerritoireIdAsync(int id);
        Employé GetTechnicienByTerritoireId(int id);
        Task<EmployéRC> GetEmployéRCByIdAsync(int id);
        EmployéRC GetEmployéRCById(int id);
        Task InitialiserEnvironnementAsync();
        int InitialiserEnvironnement();

    }
}
