using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.Infrastructure
{
    public class SolutionCleanCabloPlusContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Compte> Comptes { get; set; }
        public DbSet<Branchement> Branchements { get; set; }
        public DbSet<Equipement> Equipements { get; set; }
        public DbSet<Paiement> Paiements { get; set; }
        public DbSet<Facture> Factures { get; set; }

        public DbSet<Installation> Installations { get; set; }
        public DbSet<ClientPersonne> ClientPersonnes { get; set; }
        public DbSet<ClientEntreprise> ClientEntreprises { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<ServiceDiffusion> ServiceDiffusions { get; set; }
        public DbSet<Territoire> Territoires { get; set; }
        public DbSet<EstDesserviDans> EstDesserviDans { get; set; }
        public DbSet<LoueFilm> LoueFilms { get; set; }
        public DbSet<Employé> Employés { get; set; }
        public DbSet<EmployéRC> EmployéRCs { get; set; }
        public DbSet<Technicien> Techniciens { get; set; }




        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }

        public SolutionCleanCabloPlusContext(DbContextOptions options) : base(options) { }

        public SolutionCleanCabloPlusContext() : base(new DbContextOptionsBuilder<SolutionCleanCabloPlusContext>()
                    .UseSqlServer(@"Server=.;Database=SolutionCleanCabloPlusDB;Trusted_Connection=True;")
                    .Options)
        { }
    }
}
