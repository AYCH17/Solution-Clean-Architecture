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
    public partial class GestionFacture : Form
    {
        int numéroCompte;
        IClientService clientService;
        public GestionFacture(int num,IClientService client)
        {
            clientService = client;
            numéroCompte = num;
            InitializeComponent();

            btnSelectionner.Click += btnSelectionner_Click;
            
        }

       

        private void GestionFacture_Load(object sender, EventArgs e)
        {

            IReadOnlyList<Facture> factures = clientService.GetFactureByCompteId(numéroCompte);

            foreach(Facture f in factures)
            {
                if(f.payée)
                grdFactures.Rows.Add(f.Id, f.date, f.montantEquipements + f.montantFilms + f.montantInstallation + f.montantServicesDiffusion, "OUI");
               else
                    grdFactures.Rows.Add(f.Id, f.date, f.montantEquipements + f.montantFilms + f.montantInstallation + f.montantServicesDiffusion, "NON");

            }

            grdFactures.AllowUserToOrderColumns = true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSelectionner_Click(object sender, EventArgs e)
        {
            if (grdFactures.SelectedRows.Count==0)
                return;
            int numéroFacture = Util.StringToInt(grdFactures.SelectedRows[0].Cells[0].Value.ToString());
            ConsulterFacture formConsulterFacture = new ConsulterFacture(numéroFacture, numéroCompte, clientService);
            formConsulterFacture.ShowDialog();
        }
    }
}
