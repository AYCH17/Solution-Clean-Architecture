using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.TestsUnitaires.Core.Entities.TransactionTest
{
    public class AddPaiement
    {
        [Fact]

        public void AjouterPaiement()
        {
            Transaction transaction = new Transaction();
            transaction.AddPaiement(new PaiementEspèce(100, transaction));
            Assert.Single(transaction.Paiements);
        }

        
        [Theory]
        [InlineData(50, 40, false)]
        [InlineData(50, 50, true)]

        public void EstPayée(decimal volumeTransaction, decimal montantPaiement, bool estPayéeAttendu)
        {
            Transaction transaction = new Transaction();
            transaction.PrixUnitaire = 1.0M;
            transaction.Volume = volumeTransaction;
            transaction.AddPaiement(new PaiementEspèce(montantPaiement, transaction));
            Assert.Equal(estPayéeAttendu, transaction.EstPayée());
        }
    }
}
