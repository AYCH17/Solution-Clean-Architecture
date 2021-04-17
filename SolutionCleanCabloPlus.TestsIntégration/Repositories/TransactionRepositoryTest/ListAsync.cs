using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Microsoft.EntityFrameworkCore;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.Infrastructure;
using SolutionCleanCabloPlus.Core.Specifications;
namespace SolutionCleanCabloPlus.TestsIntégration.Repositories.TransactionRepositoryTest
{

    public class ListAsync
    {
        private readonly SolutionCleanCabloPlusContext _context;
        private readonly ClientRepository _ClientRepository;

        public ListAsync()
        {
            DbContextOptions<SolutionCleanCabloPlusContext> dbOptions = new DbContextOptionsBuilder<SolutionCleanCabloPlusContext>()
                  .UseInMemoryDatabase(databaseName: "Repositories.ClientRepositoryTest.ListAsync")
                  .Options;
            _context = new SolutionCleanCabloPlusContext(dbOptions);
            _ClientRepository = new ClientRepository(_context);
            InsertData();
        }
        private async Task InsertData()
        {
            int nombre = _context.Clients.CountAsync().Result;
            if (nombre <= 20)
            {
                for (int i = 1; i <= 20; i++)
                {
                    Client client = new Client("Nom" + i, "Prénom" + i, "adresse" + i, "téléphone" + i);
                    _ = await _ClientRepository.AddAsync(client);
                }
                _context.SaveChanges();
            }
        }


        [Theory]
        [InlineData("Khriss", 0, int.MaxValue, 0)]
        [InlineData("Nom", 0, int.MaxValue, 20)]

        public async Task ClientRechercheSpecification(string recherche, int item, int nbItem, int count)
        {

            ClientSearchSpecification spec = new ClientSearchSpecification(recherche, item, nbItem);
            var clients = await _ClientRepository.ListAsync(spec);
            //Validation du paging: le bon nombre d'item retourné commençant et finissant au bon endroit
            Assert.Equal(count, clients.Count);
        }

    }

}
