using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SolutionCleanCabloPlus.SharedKernel.Interfaces;
using SolutionCleanCabloPlus.SharedKernel;
using SolutionCleanCabloPlus.Infrastructure;
using SolutionCleanCabloPlus.Infrastructure.Specifications;

namespace SolutionCleanCabloPlus.Infrastructure
{
    public class EfRepository<T> : IAsyncRepository<T>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly SolutionCleanCabloPlusContext _SolutionCleanCabloPlusContext;

        public EfRepository(SolutionCleanCabloPlusContext contexte)
        {
            _SolutionCleanCabloPlusContext = contexte;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _SolutionCleanCabloPlusContext.Set<T>().AddAsync(entity);
            await _SolutionCleanCabloPlusContext.SaveChangesAsync();
            return entity;

        }

        public T Add(T entity)
        {
            _SolutionCleanCabloPlusContext.Set<T>().Add(entity);
            _SolutionCleanCabloPlusContext.SaveChanges();
            return entity;

        }

        public async Task UpdateAsync(T entity)
        {
            _SolutionCleanCabloPlusContext.Entry(entity).State = EntityState.Modified;
            await _SolutionCleanCabloPlusContext.SaveChangesAsync();
        }

        public int Update(T entity)
        {
            _SolutionCleanCabloPlusContext.Entry(entity).State = EntityState.Modified;
            return _SolutionCleanCabloPlusContext.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            _SolutionCleanCabloPlusContext.Set<T>().Remove(entity);
            await _SolutionCleanCabloPlusContext.SaveChangesAsync();
        }

        public int Delete(T entity)
        {
            _SolutionCleanCabloPlusContext.Set<T>().Remove(entity);
            return _SolutionCleanCabloPlusContext.SaveChanges();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _SolutionCleanCabloPlusContext.Set<T>().FindAsync(id);
        }

        public T GetById(int id)
        {
            return _SolutionCleanCabloPlusContext.Set<T>().Find(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _SolutionCleanCabloPlusContext.Set<T>().ToListAsync();
        }

        public IReadOnlyList<T> ListAll()
        {
            return _SolutionCleanCabloPlusContext.Set<T>().ToList();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public IReadOnlyList<T> List(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }


        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_SolutionCleanCabloPlusContext.Set<T>().AsQueryable(), spec);
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }

    }
}
