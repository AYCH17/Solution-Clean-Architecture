using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SolutionCleanCabloPlus.Core.Interfaces;

namespace SolutionCleanCabloPlus.Core.Services
{
    public class EmployéService : IEmployéService
    {
        IEmployéRCRepository _employéRCRepository;
        ITechnicienRepository _technicienRepository;
        IEmployéRepository _employéRepository;

        public EmployéService(IEmployéRepository e,IEmployéRCRepository rc, ITechnicienRepository t)
        {
            _employéRCRepository = rc;
            _employéRepository = e;
            _technicienRepository = t;
        }
        public Employé AddEmployé(Employé employé)
        {
            return _employéRepository.Add(employé);

        }

        public Task AddEmployéAsync(Employé employé)
        {
           return  _employéRepository.AddAsync(employé);
        }

        public int DeleteEmployé(Employé employé)
        {
            return _employéRepository.Delete(employé);
        }

        public Task DeleteEmployéAsync(Employé employé)
        {
            return _employéRepository.DeleteAsync(employé);
        }

        public EmployéRC GetEmployéRCById(int id)
        {
            return _employéRCRepository.GetById(id);
        }

        public Task<EmployéRC> GetEmployéRCByIdAsync(int id)
        {
            return _employéRCRepository.GetByIdAsync(id);
        }

        public Technicien GetTechnicienById(int id)
        {
            return _technicienRepository.GetById(id);
        }

        public Task<Technicien> GetTechnicienByIdAsync(int id)
        {
            return _technicienRepository.GetByIdAsync(id);
        }

        public Employé GetTechnicienByTerritoireId(int id)
        {
            return _technicienRepository.GetByTerritoireId(id);
        }

        public Task<Employé> GetTechnicienByTerritoireIdAsync(int id)
        {
            return _technicienRepository.GetByTerritoireIdAsync(id);
        }

        public int InitialiserEnvironnement()
        {
            throw new NotImplementedException();
        }

        public Task InitialiserEnvironnementAsync()
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployé(Employé employé)
        {
            return _employéRepository.Update(employé);
        }

        public Task UpdateEmployéAsync(Employé employé)
        {
            return _employéRepository.UpdateAsync(employé);
        }
    }
}
