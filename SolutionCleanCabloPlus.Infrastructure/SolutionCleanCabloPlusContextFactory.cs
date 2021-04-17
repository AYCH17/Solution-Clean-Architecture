using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SolutionCleanCabloPlus.Infrastructure
{
    public class SolutionCleanCabloPlusContextFactory : IDesignTimeDbContextFactory<SolutionCleanCabloPlusContext>
    {
        public SolutionCleanCabloPlusContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SolutionCleanCabloPlusContext>();
            optionsBuilder.UseSqlServer(@"Server=.;Database=SolutionCleanCabloPlusDB;Trusted_Connection=True;");

            return new SolutionCleanCabloPlusContext(optionsBuilder.Options);
        }
    }
}
