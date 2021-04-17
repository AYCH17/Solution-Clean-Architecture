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
    public partial class ConsulterCompte : Form
    {
        private int numéroCompte;
        private readonly IClientService clientService;
        public ConsulterCompte(int num, IClientService clientService)
        {
            numéroCompte = num;
            this.clientService = clientService;

            InitializeComponent();
        }

        private void ConsulterCompte_Load(object sender, EventArgs e)
        {

            txtNumero.Text = numéroCompte.ToString();

            Compte compte =  clientService.GetCompteById(numéroCompte);

            Client client = clientService.GetClientByCompteId(compte.Id);

            ClientPersonne clientP = clientService.GetClientPersonneById(client.Id);
            if (clientP == null)
            {
                ClientEntreprise clientE = clientService.GetClientEntrepriseById(client.Id);
                txtNom.Text = clientE.raisonSociale;

            }
            else
                txtNom.Text = clientP.nom + " " + clientP.prénom;

            IReadOnlyList<ServiceDiffusion> serviceDiffusions = clientService.GetServiceDiffusionByCompteId(compte.Id);
            IReadOnlyList<Equipement> equipements = clientService.GetEquipementByCompteId(compte.Id);
            foreach(ServiceDiffusion s in serviceDiffusions)
                    lstServices.Items.Add(s.nom);  ///////
            foreach(Equipement eq in equipements)
                lstEquipements.Items.Add(eq.nom);     ///////



        }



    }
}
