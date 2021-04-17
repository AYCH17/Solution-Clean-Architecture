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
    public partial class ConsulterInstallation : Form
    {
        IClientService clientService;
        int technicienId;
        public ConsulterInstallation(IClientService clientService, int technicienId)
        {
            this.clientService = clientService;
            this.technicienId = technicienId;
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsulterInstallation_Load(object sender, EventArgs e)
        {
            dateNow.Value = DateTime.Now;
            dateNow.Enabled = false;
            dateFin.Value = DateTime.Now;
            grdInstallation.MultiSelect = false;

        }

        private void Selectionner_Click(object sender, EventArgs e)
        {
            if (grdInstallation.SelectedRows == null)
                return;

            
            int numéro = Util.StringToInt(grdInstallation.SelectedRows[0].Cells[0].Value.ToString());
            Installation installation = clientService.GetInstallationById(numéro);

            Compte compte = clientService.GetCompteByInstallationId(installation.Id);
            
            txtNumero.Text = compte.Id.ToString();

            Client client = clientService.GetClientByCompteId(compte.Id);

            txtAdresse.Text = client.adresse;

            ClientPersonne clientP = clientService.GetClientPersonneById(client.Id);
            if (clientP == null)
            {
                ClientEntreprise clientE = clientService.GetClientEntrepriseById(client.Id);
                txtNom.Text = clientE.raisonSociale;

            }
            else
                txtNom.Text = clientP.nom + " " + clientP.prénom;

            txtTelephone.Text =client.téléphone;
            txtDateProgrammation.Text = installation.dateProgramation.Date.ToString();

        }

        private void dateFin_ValueChanged(object sender, EventArgs e)
        {
            grdInstallation.Rows.Clear();

            IReadOnlyList<Installation> installationsByDate = clientService.GetInstallationByDate(dateFin.Value);

            IReadOnlyList<Installation> installationsByTechnicien = clientService.GetInstallationByTechnicienId(technicienId);

            foreach (Installation i in installationsByDate)
            {
                if(installationsByTechnicien.Contains(i))
                {
                    Compte compte = clientService.GetCompteByInstallationId(i.Id);
                    Client client = clientService.GetClientByCompteId(compte.Id);

                    grdInstallation.Rows.Add(i.Id, i.dateProgramation, client.adresse);
                }
                            
                
            }
        }

        private void btnConfirmerInstallation_Click(object sender, EventArgs e)
        {
            if (grdInstallation.SelectedRows.Count == 0 || grdInstallation.SelectedRows[0].Cells[0].Value==null)
                return;
            int numéro = Util.StringToInt(grdInstallation.SelectedRows[0].Cells[0].Value.ToString());
            Installation installation = clientService.GetInstallationById(numéro);
            installation.dateRéalisation = DateTime.Now;

            clientService.UpdateInstallation(installation);
            txtDateRealisation.Text = DateTime.Now.ToString();
            MessageBox.Show("installation confirmée \n " + DateTime.Now.ToString());
        }
    }
}
