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
    public partial class ModifierClient : Form
    {
        int numéroClient;
        IClientService clientService;
        Client client;
        bool estPersonne;
        public ModifierClient(int num, IClientService clientService)
        {
            numéroClient = num;
            this.clientService = clientService;
           
          
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Confirmer_Click(object sender, EventArgs e)
        {

            client.adresse = txtAdresse.Text;
            client.territoire = clientService.GetTerritoireByNom(txtTerritoire.Text)[0];
            client.téléphone = txtTelephone.Text;

            clientService.UpdateClient(client);

            Close();


        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {
            client = clientService.GetClientById(numéroClient);
            

            txtAdresse.Text = client.adresse;
            txtNumero.Text = client.Id.ToString();
            txtTelephone.Text = client.téléphone;
            txtTerritoire.Text = clientService.GetTerritoireByClientId(client.Id).nom;

            txtNumero.Enabled = false;
        }
    }
}
