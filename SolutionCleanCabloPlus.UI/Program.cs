using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SolutionCleanCabloPlus.Core.Interfaces;
using SolutionCleanCabloPlus.Core.Services;


using SolutionCleanCabloPlus.Infrastructure;

namespace SolutionCleanCabloPlus.UI
{

    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new HostBuilder()
            .ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<SolutionCleanCabloPlusContext>(options => options.UseSqlServer(@"Server=.;Database=SolutionCleanCabloPlusDB;Trusted_Connection=True;"));
                services.AddSingleton<GestionComptes>();
                services.AddSingleton<Authentification>();
                services.AddLogging(configure => configure.AddConsole());
                services.AddScoped<IEquipementRepository, EquipementRepository>();
                services.AddScoped<IInstallationRepository, InstallationRepository>();
                services.AddScoped<ICompteRepository, CompteRepository>();
                services.AddScoped<IClientRepository, ClientRepository>();
                services.AddScoped<IEstDesserviDansRepository, EstDesserviDansRepository>();
                services.AddScoped<IServiceDiffusionRepository, ServiceDiffusionRepository>();
                services.AddScoped<ITerritoireRepository, TerritoireRepository>();
                services.AddScoped<ITechnicienRepository, TechnicienRepository>();
                services.AddScoped<IFactureRepository, FactureRepository>();
                services.AddScoped<IBranchementRepository, BranchementRepository>();
                services.AddScoped<ILoueFilmRepository, LoueFilmRepository>();
                services.AddScoped<IPaiementRepository, PaiementRepository>();
                services.AddScoped<IClientEntrepriseRepository, ClientEntrepriseRepository>();
                services.AddScoped<IClientPersonneRepository, ClientPersonneRepository>();
                services.AddScoped<IEmployéRepository, EmployéRepository>();
                services.AddScoped<IEmployéRCRepository, EmployéRCRepository>();
                services.AddScoped<IFilmRepository, FilmRepository>();









                services.AddScoped<IInstallationService, InstallationService>();
                services.AddScoped<IFacturationService, FacturationService>();
                services.AddScoped<IClientService, ClientService>();
                services.AddScoped<IEmployéService, EmployéService>();

            });

            var host = builder.Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var forms = services.GetRequiredService<Authentification>();
                    Application.Run(forms);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                
                }

            }
        }
    }
}

