using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.Core.Interfaces;
using SolutionCleanCabloPlus.Core.Services;
using Moq;
namespace SolutionCleanCabloPlus.TestsUnitaires.Core.Services.TransactionTest
{
    public class AddTransactionAvecPaiement
    {
        private Mock<ITransactionRepository> _mockTransactionRepository;
        private Mock<IPompeRepository> _mockPompeRepository;

        public AddTransactionAvecPaiement()
        {
            _mockTransactionRepository = new Mock<ITransactionRepository>();
            _mockPompeRepository = new Mock<IPompeRepository>();
        }


        [Fact]
        public async void AjouterTransactionAvecPaiement()
        {
            //1ère étape : configuration des mocks pour qu'ils retournes les bons objets
            Pompe pompe = new Pompe { Id = 1 };
            _mockPompeRepository.Setup(x => x.GetByIdWithRéservoirAsync(pompe.Id)).ReturnsAsync(pompe);
            Transaction transaction = new Transaction { Id = 1 };
            transaction.Pompe = pompe;
            transaction.PrixUnitaire = 1.0M;
            transaction.Volume = 50.0M;
            _mockTransactionRepository.Setup(x => x.GetByIdWithPaiementsAsync(transaction.Id)).ReturnsAsync(transaction);

            //2ème étape : appeler le service
            TransactionService service = new TransactionService(_mockTransactionRepository.Object, null);
            await service.AddTransactionAsync(transaction);
            Paiement paiement = new PaiementEspèce(50, transaction);
            await service.AddPaiementAsync(transaction.Id, paiement);
            
            //3ème étape: vérifier les appels aux repositories
            _mockTransactionRepository.Verify(x => x.AddAsync(transaction), Times.Once);
            _mockTransactionRepository.Verify(x => x.GetByIdWithPaiementsAsync(1), Times.Once);
            _mockTransactionRepository.Verify(x => x.UpdateAsync(transaction), Times.Once);
            _mockTransactionRepository.VerifyNoOtherCalls();

            //4éme étape: vérifier les valeurs finales
            Assert.Single(transaction.Paiements);
            Assert.Equal(50.0M, transaction.MontantTotal());
            Assert.Equal(true, transaction.EstPayée());




        }


    }
}
