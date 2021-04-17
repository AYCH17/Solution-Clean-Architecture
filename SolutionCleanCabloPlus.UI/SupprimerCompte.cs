using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.Core.Interfaces;

namespace SolutionCleanCabloPlus.UI
{
    public partial class SupprimerCompte : Form
    {
        int numéroCompte;
        IClientService clientService;
        IFacturationService facturationService;
        public SupprimerCompte(int numéroCompte,IClientService clientService, IFacturationService facturationService)
        {
            this.numéroCompte = numéroCompte;
            this.clientService = clientService;
            this.facturationService = facturationService;
            InitializeComponent();
        }

        private void pmtConfirmation_Enter(object sender, EventArgs e)
        {

        }

        private void supprimerCompte_Load(object sender, EventArgs e)
        {
            txtMontantDu.Text = facturationService.CalculerMontantFacturesNonPayees(numéroCompte).ToString();
            txtNuméroCompte.Text = numéroCompte.ToString();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (txtMontantDu.Text != "0")
            {
                errMontantDu.Visible = true;
                return;
            }

            pmtConfirmation.Visible = true;

        }

        private void btnOui_Click(object sender, EventArgs e)
        {  
            try
            {
                clientService.DeleteCompte(clientService.GetCompteById(numéroCompte));

            }
            catch
            
            {
                MessageBox.Show("Ce compte ne peut pas être supprimé !");
            }

            this.Close();
        }

        private void btnNon_Click(object sender, EventArgs e)
        {
            pmtConfirmation.Visible = false;

        }
    }
}
