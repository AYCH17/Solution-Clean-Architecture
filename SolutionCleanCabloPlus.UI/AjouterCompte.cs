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
    public partial class AjouterCompte : Form
    {
        private int numéroClient;
        private readonly IClientService clientService;
        private readonly IFacturationService facturationService;

        private List<ServiceDiffusion> services = new List<ServiceDiffusion>();
        private List<Equipement> equipements = new List<Equipement>();

        public AjouterCompte(int numéroClient,IClientService clientService, IFacturationService facturationService)
        {
            this.facturationService = facturationService;
            this.clientService = clientService;
            this.numéroClient = numéroClient;
            InitializeComponent();
            InitialiserForm();
        }



        private void InitialiserForm()
        {
            IReadOnlyList<EstDesserviDans> est = clientService.GetEstDesserviDansByTerritoireId(clientService.GetTerritoireByClientId(numéroClient).Id);
            
            foreach(EstDesserviDans e in est)
            {
                services.Add(e.serviceDiffusion);
                chkServices.Items.Add(e.serviceDiffusion.nom);
            }


            IReadOnlyList<Equipement> _equipements = clientService.GetAllEquipements();
            foreach (Equipement e in _equipements)
            {
                bool existe = false;
                foreach(Equipement e1 in equipements)
                {
                    if (e1.nom == e.nom)
                    {
                        existe = true;
                        break;
                    }
                        
                }

                if (existe == false)
                {
                    equipements.Add(e);
                    chkEquipements.Items.Add(e.nom);
                }
                    

               


            }


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if(chkModeFacturation.Text == null || chkServices.CheckedItems.Count == 0 || chkEquipements.CheckedItems.Count==0)
            {
                errVide.Visible = true;
                return;
            }

            List<Equipement> _equipements = new List<Equipement>();
            List<ServiceDiffusion> _services = new List<ServiceDiffusion>();
            ModeFacturation mode;

            foreach (Equipement i in equipements)
            {
                if(chkEquipements.CheckedItems.Contains(i.nom))
                {
                    _equipements.Add(i);
                }
            }

            foreach(ServiceDiffusion i in services)
            {
                if (chkServices.Items.Contains(i.nom))
                    _services.Add(i);
            }

            if (chkModeFacturation.Text == "Mensuel")
                mode = ModeFacturation.Mensuel;
            else
                mode = ModeFacturation.Annuel;

            Client client = clientService.GetClientById(numéroClient);
            Compte compte = new Compte(mode, client, clientService.GetEmployéRCByID(Session.employéRCID));
            compte.equipements = _equipements;
            compte.serviceDiffusions = _services;

             compte =   clientService.AddCompte(compte) ;

            IReadOnlyList<Branchement> _branchements = clientService.GetBranchementByLocalisation(client.adresse);
            if(_branchements.Count==0)
            {
                Employé technicien = clientService.GetTechnicienByTerritoireID(clientService.GetTerritoireByClientId(client.Id).Id);
                //MessageBox.Show(technicien.Id.ToString());
                Installation installation =  clientService.AddInstallation(new Installation(100,DateTime.MinValue,DateTime.MinValue,compte,technicien));
                clientService.AddBranchement(new Branchement(client.adresse, compte, installation));
                facturationService.AddFacture(compte, installation);
            }
            else
            {
                facturationService.AddFacture(compte, null);
            }

            Close();
        }
    }
}
