using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolutionCleanCabloPlus.Core.Interfaces;
using SolutionCleanCabloPlus.Core;

namespace SolutionCleanCabloPlus.UI
{
    public partial class AjouterClient : Form
    {
        IClientService clientService;
        IFacturationService facturationService;

        public AjouterClient(IClientService clientService,IFacturationService facturationService)
        {
            this.facturationService = facturationService;
            this.clientService = clientService;
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if(txtAdresse.Text=="" || txtAdresse == null)
            {
                errAdresse.Visible = true;
                return;
            }

            if (txtTelephone.Text == "" || txtTelephone == null)
            {
                errTelephone.Visible = true;
                return;
            }

            if (txtTerritoire.Text == "" || txtTerritoire == null)
            {
                errTerritoire.Visible = true;
                return;
            }

            if ((txtRaisonSociale.Text == "" || txtRaisonSociale == null) & ((txtNom.Text == "" || txtNom == null) || (txtPrenom.Text == "" || txtPrenom == null)))
            {
                errNomVide.Visible = true;
                return;
            }

            if ((txtRaisonSociale.Text != "" & txtRaisonSociale != null) & ((txtNom.Text != "" & txtNom != null) || (txtPrenom.Text != "" & txtPrenom != null)))
            {
                errNomVide.Visible = true;
                return;
            }

            if(txtRaisonSociale.Text != "" & txtRaisonSociale != null)
            {
                Territoire territoire = clientService.GetTerritoireByNom(txtTerritoire.Text)[0];
                ClientEntreprise client = 
                 clientService.AddClientEntreprise(new ClientEntreprise(txtTelephone.Text, txtAdresse.Text, territoire, txtRaisonSociale.Text));

                MessageBox.Show(client.raisonSociale);
                
              
                AjouterCompte formAjouterCompte = new AjouterCompte(client.Id,clientService,facturationService);
                formAjouterCompte.ShowDialog();
              
            }

            if (txtNom.Text != "" & txtNom != null)
            {
                Territoire territoire = clientService.GetTerritoireByNom(txtTerritoire.Text)[0];
                ClientPersonne client = clientService.AddClientPersonne(new ClientPersonne(txtTelephone.Text, txtAdresse.Text, territoire, txtNom.Text,txtPrenom.Text));
                AjouterCompte formAjouterCompte = new AjouterCompte(client.Id,clientService, facturationService);
                formAjouterCompte.ShowDialog();
            }

            


        }

       
    }
}
