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
    public partial class ConsulterFacture : Form
    {
        int numéroFacture;
        int numéroCompte;
        IClientService clientService;
        public ConsulterFacture(int numFacture, int numCompte, IClientService clientService)
        {
            numéroFacture = numFacture;
            numéroCompte = numCompte;
            this.clientService = clientService;
            InitializeComponent();
        }

        private void ConsulterFacture_Load(object sender, EventArgs e)
        {
            txtNumeroCompte.Text = numéroCompte.ToString();
            Facture facture = clientService.GetFactureById(numéroFacture);
            txtFraisInstallation.Text = facture.montantInstallation.ToString();
            txtTarifEquipement.Text = facture.montantEquipements.ToString();
            txtTarifService.Text = facture.montantServicesDiffusion.ToString();
            txtTarifFilms.Text = facture.montantFilms.ToString();
            dateFacture.Value = facture.date;

            txtTotal.Text = (facture.montantEquipements + facture.montantFilms + facture.montantServicesDiffusion + facture.montantInstallation).ToString();

            txtFraisInstallation.Enabled = false;
            txtTarifEquipement.Enabled = false;
            txtTarifService.Enabled = false;
            txtTarifFilms.Enabled = false;
            txtTotal.Enabled = false;

        }

        private void Confirmer_Click(object sender, EventArgs e)
        {

            if (txtEspece.Text == null || txtEspece.Text == "" || txtNumeroCarte.Text == null || txtNumeroCarte.Text == "")
            {
                errVide.Visible = true;
                return;
            }

            if (txtEspece.Text != null & txtEspece.Text != "" & txtNumeroCarte.Text == null & txtNumeroCarte.Text == "")

            {
                errVide.Visible = true;
                return;
            }


            Compte compte = clientService.GetCompteById(numéroCompte);
            decimal solde = compte.solde;

            if (txtEspece.Text != null & txtEspece.Text != "")
            {
                if(solde+Util.StringToInt(txtEspece.Text) < Util.StringToInt(txtTotal.Text))
                {
                    errMontant.Visible = true;
                    return;
                }

                Facture facture = clientService.GetFactureById(numéroFacture);


                compte.solde += Util.StringToInt(txtEspece.Text) - Util.StringToInt(txtTotal.Text);
                txtRestant.Text = compte.solde.ToString();
                facture.payée = true;

                clientService.UpdateCompte(compte);

                clientService.AddPaiement(new Paiement(Util.StringToInt(txtTotal.Text), DateTime.Now, compte,facture));

                

            }

            

        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
