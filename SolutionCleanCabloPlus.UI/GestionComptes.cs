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
    public partial class GestionComptes : Form
    {
        private readonly IClientService clientService;
        private readonly IFacturationService facturationService;
        


        public GestionComptes(IClientService clientService, IFacturationService facturationService)
        {

            //InitialiserEnvironnementAsync();
            this.clientService = clientService;
            this.facturationService = facturationService;

            InitializeComponent();
            this.backgroundWorkerFacturation.RunWorkerAsync();


            cmbChercherClient.TextChanged += CmbChercherClient_TextChanged;
            cmbChercherCompte.TextChanged += CmbChercherCompte_TextChanged;
            cmbChercherCompte.SelectionChangeCommitted += CmbChercherCompte_SelectionChangeCommitted;
            cmbChercherClient.SelectionChangeCommitted += CmbChercherClient_SelectionChangeCommitted;
            grdComptes.SelectionChanged += GrdComptes_SelectionChanged;
            cmbTerritoire.TextChanged += CmbTerritoire_TextChanged;
            cmbTerritoire.SelectionChangeCommitted += CmbTerritoire_SelectionChangeCommitted;
            btnAjouterClient.Click += BtnAjouterClient_Click;


            btnAjouterCompte.Enabled = false;
            btnConsulterClient.Enabled = false;
            btnConsulterCompte.Enabled = false;
            btnConsulterFacture.Enabled = false;
            btnModifierClient.Enabled = false;
            btnModifierCompte.Enabled = false;
            btnSupprimerCompte.Enabled = false;
            btnVoirFilm.Enabled = false;



        }

        private void BtnAjouterClient_Click(object sender, EventArgs e)
        {
            AjouterClient formAjouterClient = new AjouterClient(clientService, facturationService);
            formAjouterClient.ShowDialog();
        }

        private void CmbTerritoire_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Territoire territoire = clientService.GetTerritoireByNom(cmbTerritoire.SelectedItem.ToString())[0];





            errTerritoire.Visible = false;
            succesTerritoire.Visible = false;
            
            if (clientService.GetEstDesserviDansByTerritoireId(territoire.Id).Count == 0)
                errTerritoire.Visible = true;
            else
                succesTerritoire.Visible = true;
        }

        private void CmbTerritoire_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbChercherClient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

            if (cmbChercherClient.SelectedItem == null)
                return;

            List<Compte> comptes = new List<Compte>();

            ClientPersonne client = clientService.SearchClientPersonnes(cmbChercherClient.SelectedItem.ToString(),1,5)[0];
            if(client==null)
            {
               ClientEntreprise client1 = clientService.SearchClientEntreprises(cmbChercherClient.SelectedItem.ToString(), 1, 5)[0];
                comptes = (List<Compte>)clientService.GetCompteByClientId(client1.Id);

            }   
            else
                comptes = (List<Compte>)clientService.GetCompteByClientId(client.Id);


            

            foreach (Compte c in comptes)
            {
                grdComptes.Rows.Add(c.Id, c.solde);

            }

            

            cmbChercherClient.Items.Clear();

        }

        private void CmbChercherClient_TextChanged(object sender, EventArgs e)
        {
            IReadOnlyList<ClientEntreprise> clientsE = clientService.SearchClientEntreprises(cmbChercherClient.Text,1,5); // bullshit to correct
            IReadOnlyList<ClientPersonne> clientsP = clientService.SearchClientPersonnes(cmbChercherClient.Text, 1, 5); // bullshit to correct

            if (clientsE == null & clientsP == null)
                return;

           
            // vider la data grid view
            grdComptes.Rows.Clear();
            grdComptes.Refresh();

            int i;
            foreach (ClientEntreprise c in clientsE)
            {
                 i = cmbChercherClient.Items.Add(c.raisonSociale);
                 
            }

            foreach (ClientPersonne c in clientsP)
            { 
                i = cmbChercherClient.Items.Add(c.nom+" "+c.prénom);
                
            }
            

        }

        private void GrdComptes_SelectionChanged(object sender, EventArgs e)
        {
            if (grdComptes.SelectedRows.Count==0 || grdComptes.SelectedRows[0].Cells[0].Value == null)
                return;



            int numéro = (int) grdComptes.SelectedRows[0].Cells[0].Value;

            //MessageBox.Show(numéro.ToString());
           
            Compte compte = clientService.GetCompteById(numéro);

            txtModeFacture.Text = compte.modeFacturation.ToString();

            Client client = clientService.GetClientByCompteId(compte.Id);

            ClientPersonne clientP = clientService.GetClientPersonneById(client.Id);
            
            if (clientP == null)
            {
                ClientEntreprise clientE = clientService.GetClientEntrepriseById(client.Id);
                txtNomClient.Text = clientE.raisonSociale;

            }
            else
                txtNomClient.Text = clientP.nom + " " + clientP.prénom;

            txtSolde.Text = compte.solde.ToString();
            txtNumeroCompte.Text = compte.Id.ToString();


            btnConsulterCompte.Enabled = true;
            btnConsulterFacture.Enabled = true;
            btnModifierCompte.Enabled = true;
            btnSupprimerCompte.Enabled = true;
            btnVoirFilm.Enabled = true;
            btnModifierClient.Enabled = true;
            btnConsulterClient.Enabled = true;
            btnAjouterCompte.Enabled = true;
            
        }

        private void CmbChercherCompte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbChercherCompte.Items.Clear();
            grdComptes.Rows.Clear();

            int numéro = Util.StringToInt(cmbChercherCompte.Text);
            Compte compte = clientService.GetCompteById(numéro);

            txtModeFacture.Text = compte.modeFacturation.ToString();
            txtSolde.Text = compte.solde.ToString();
            txtNumeroCompte.Text = compte.Id.ToString();

            Client client = clientService.GetClientByCompteId(compte.Id);

            ClientPersonne clientP = clientService.GetClientPersonneById(client.Id);
            if (clientP == null)
            {
                ClientEntreprise clientE = clientService.GetClientEntrepriseById(client.Id);
                txtNomClient.Text = clientE.raisonSociale;

            }
            else
                txtNomClient.Text = clientP.nom + " " + clientP.prénom;
            
            

            IReadOnlyList<Compte> comptes = clientService.GetCompteByClientId(client.Id);

            //MessageBox.Show(grdComptes.Rows.Count.ToString());

            
            

            foreach(Compte c in comptes) ////////////////////////
            {
                grdComptes.Rows.Add(c.Id, c.solde);
            }

            grdComptes.Refresh();
            

        }

        private void  CmbChercherCompte_TextChanged(object sender, EventArgs e)
        {
            int numéro = Util.StringToInt(cmbChercherCompte.Text);
            if(numéro == int.MinValue)
            {
                //do show error
                return;
            }

            Compte compte = clientService.GetCompteById(numéro);
            if(compte == null)
            {
                //do show error
                return;
            }

            cmbChercherCompte.Items.Add(numéro);
            cmbChercherCompte.DroppedDown = true;

        }

        private void AjouterCompte_Click(object sender, EventArgs e)
        {
            if (grdComptes.SelectedRows.Count == 0)
                return;
            Client client = clientService.GetClientByCompteId(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()));
            AjouterCompte formAjouterCompte = new AjouterCompte(client.Id,clientService,facturationService);
            formAjouterCompte.ShowDialog();
        }

        

        private void ConsulterCompte_Click(object sender, EventArgs e)
        {if (grdComptes.SelectedRows.Count == 0)
                return;
           
            ConsulterCompte formConsulterCompte = new ConsulterCompte(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()), clientService);
            formConsulterCompte.ShowDialog();
        }

        private void ConsulterClient_Click(object sender, EventArgs e)
        {
            if (grdComptes.SelectedRows.Count == 0)
                return;

            Client client = clientService.GetClientByCompteId(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()));

            ConsulterClient formConsulterClient = new ConsulterClient(client.Id,clientService);
            formConsulterClient.ShowDialog();
        }

        private void ModifierCompte_Click(object sender, EventArgs e)
        {
            if (grdComptes.SelectedRows.Count == 0)
                return;

            ModifierCompte formModifierCompte = new ModifierCompte(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()), clientService);
            formModifierCompte.ShowDialog();
        }

        private void ModifierClient_Click(object sender, EventArgs e)
        {
            if (grdComptes.SelectedRows.Count == 0)
                return;
            Client client = clientService.GetClientByCompteId(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()));

            ModifierClient formModifierClient = new ModifierClient(client.Id, clientService);
            formModifierClient.ShowDialog();
        }

        private void SupprimerCompte_Click(object sender, EventArgs e)
        {
            if (grdComptes.SelectedRows.Count == 0)
                return;
            SupprimerCompte formSupprimerCompte = new SupprimerCompte(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()),clientService,facturationService);
            formSupprimerCompte.ShowDialog();
        }

        private void VoirFilm_Click(object sender, EventArgs e)
        {
            VoirFilm formVoirFilm = new VoirFilm(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()),clientService);
            formVoirFilm.ShowDialog();
        }

        private void ConsulterFacture_Click(object sender, EventArgs e)
        {
            GestionFacture formGestionFacture = new GestionFacture(Util.StringToInt(grdComptes.SelectedRows[0].Cells[0].Value.ToString()),clientService  );
            formGestionFacture.ShowDialog();
        }

        

       
    }
}
