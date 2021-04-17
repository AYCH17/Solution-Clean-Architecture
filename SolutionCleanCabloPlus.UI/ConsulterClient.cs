using System;
using System.Windows.Forms;
using SolutionCleanCabloPlus.Core;
using SolutionCleanCabloPlus.Core.Interfaces;
namespace SolutionCleanCabloPlus.UI
{
    public partial class ConsulterClient : Form
    {
        private int numéroClient;
        private readonly IClientService clientService;
        public ConsulterClient(int num, IClientService clientService)
        {
            this.clientService = clientService;
            numéroClient = num;
            InitializeComponent();
        }

        private void ConsulterClient_Load(object sender, EventArgs e)
        {
            Client client = clientService.GetClientById(numéroClient);
            txtAdresse.Text = client.adresse;
            txtNumero.Text = client.Id.ToString();
            txtTelephone.Text = client.téléphone;

            txtTerritoire.Text = clientService.GetTerritoireByClientId(client.Id).nom;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
