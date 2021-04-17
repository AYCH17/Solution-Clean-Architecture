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
using SolutionCleanCabloPlus.UI;

namespace SolutionCleanCabloPlus
{
    public partial class Authentification : Form
    {
         
        IFacturationService facturationService;
        IClientService clientService;
        public Authentification(IClientService clientService, IFacturationService facturationService)
        {
            this.facturationService = facturationService;
            this.clientService = clientService;
            
            InitialiserEnvironnement();
            InitializeComponent();
        }

        public Task InitialiserEnvironnementAsync()
        {
            return clientService.InitialiserEnvironnementAsync();

        }

        public int InitialiserEnvironnement()
        {
            return clientService.InitialiserEnvironnement();
        }

        private void btnEntrer_Click(object sender, EventArgs e)
        {
            if(txtEmployéId.Text == null || txtEmployéId.Text =="" || txtMdp.Text == null || txtMdp.Text=="" || Util.StringToInt(txtEmployéId.Text)==int.MinValue)
            {
                errIncorrect.Visible = true;
                return;
            }

            Technicien employét = clientService.GetTechnicienByID(Util.StringToInt(txtEmployéId.Text));
            if(employét == null)
            {
                EmployéRC employérc = clientService.GetEmployéRCByID(Util.StringToInt(txtEmployéId.Text));
                if (employérc == null)
                    errIncorrect.Visible = true;
                else
                {
                    if(txtMdp.Text != employérc.mdp)
                        errIncorrect.Visible = true;
                    else
                    {
                        Session.employéRCID = employérc.Id;
                        GestionComptes formGestionComptes = new GestionComptes(clientService, facturationService);
                        formGestionComptes.ShowDialog();
                        this.Close();
                    }
                }
          
            }

            else
            {
                if (txtMdp.Text != employét.mdp)
                    errIncorrect.Visible = true;
                else
                {
                    Session.technicienID = employét.Id;
                    GestionInstallation formGestionInstallation = new GestionInstallation(clientService);
                    formGestionInstallation.ShowDialog();
                    this.Close();
                }
            }



        }

        private void chkAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfficherMdp.Checked)
                txtMdp.UseSystemPasswordChar = false;
            else
                txtMdp.UseSystemPasswordChar = true;
        }
    }
}
