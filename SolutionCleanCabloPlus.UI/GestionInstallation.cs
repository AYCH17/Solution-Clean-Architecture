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
    public partial class GestionInstallation : Form
    {
        IClientService clientService;
        public GestionInstallation(IClientService clientService)
        {
            this.clientService = clientService;
            InitializeComponent();
            
        }

        private void GestionInstallation_Load(object sender, EventArgs e)
        {
            IReadOnlyList<Installation> installations = clientService.GetAllInstallations();
            foreach(Installation i in installations)
            {
                if(i.dateProgramation == DateTime.MinValue)
                {
                    Compte compte = clientService.GetCompteByInstallationId(i.Id);
                    grdInstallations.Rows.Add(i.Id, compte.Id, "__/__/__");
                }
            }
        }

        private void btnAjoutDate_Click(object sender, EventArgs e)
        {
            if (grdInstallations.SelectedRows.Count==0 || grdInstallations.SelectedRows[0].Cells[0].Value == null)
                return;
            
            DateTime dateProgrammation = dateAjoutee.Value;
            if(DateTime.Compare(dateProgrammation,DateTime.Now) <0)
            {
                MessageBox.Show("Date invalide !");
                return;
            }

            grdInstallations.SelectedRows[0].Cells[2].Value = dateProgrammation.ToLongDateString();
            Installation installation = clientService.GetInstallationById(Util.StringToInt(grdInstallations.SelectedRows[0].Cells[0].Value.ToString()));

            installation.dateProgramation = dateProgrammation;
            clientService.UpdateInstallation(installation);

        }



        private void btnConsulterDisponibles_Click(object sender, EventArgs e)
        {
            ConsulterInstallation formConsulterInstallation = new ConsulterInstallation(clientService, Session.technicienID);
            formConsulterInstallation.ShowDialog();
        }
    }
}
