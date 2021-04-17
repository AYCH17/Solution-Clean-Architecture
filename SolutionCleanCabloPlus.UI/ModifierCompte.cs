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

    
    public partial class ModifierCompte : Form
    {
        int numéroCompte;
        IClientService clientService;
        

        public ModifierCompte(int num,IClientService clientService)
        {
            numéroCompte = num;
            this.clientService = clientService;
            InitializeComponent();
        }

        private void Confirmer_Click(object sender, EventArgs e)
        {
            
            if (chkEquipements.CheckedItems == null || chkServices.CheckedItems == null)
                return;

            Compte compte = clientService.GetCompteById(numéroCompte);


            Equipement equipement;
            List<Equipement> equipements = new List<Equipement>();
            foreach(string  eq in chkEquipements.CheckedItems)
            {
                equipement = clientService.GetEquipementByNom(eq)[0];
                equipements.Add(equipement);
            }

            
            
            compte.equipements.Clear();
            compte.equipements = new List<Equipement>(equipements);

            clientService.UpdateCompte(compte);

           

            ServiceDiffusion serviceDiffusion;
            List<ServiceDiffusion> serviceDiffusions = new List<ServiceDiffusion>();
            foreach (string s in chkServices.CheckedItems)
            {
                serviceDiffusion = clientService.GetServiceByNom(s)[0];
                serviceDiffusions.Add(serviceDiffusion);
            }

            compte.serviceDiffusions = new List<ServiceDiffusion>(serviceDiffusions);

            clientService.UpdateCompte(compte);

            this.Close();
        }

        private void ModifierCompte_Load(object sender, EventArgs e)
        {
            txtNumero.Text = numéroCompte.ToString();
            Client client = clientService.GetClientByCompteId(numéroCompte);

            ClientEntreprise clientEntreprise = clientService.GetClientEntrepriseById(client.Id);
            if (clientEntreprise == null)
            {
                ClientPersonne clientPersonne = clientService.GetClientPersonneById(client.Id);
                txtNom.Text = clientPersonne.nom + clientPersonne.prénom;

            }

            else
                txtNom.Text = clientEntreprise.raisonSociale;

            IReadOnlyList<EstDesserviDans> ests = clientService.GetEstDesserviDansByTerritoireId(clientService.GetTerritoireByClientId(client.Id).Id);
            foreach (EstDesserviDans est in ests)
            {
                ServiceDiffusion service = clientService.GetServiceDiffusionByEstDesserviDans(est.Id);

                chkServices.Items.Add(service.nom);
            }


            IReadOnlyList<Equipement> _equipements = clientService.GetAllEquipements();
            List<Equipement> equipements1 = new List<Equipement>();
            foreach (Equipement eq in _equipements)
            {
                bool existe = false;
                foreach (Equipement e1 in equipements1)
                {
                    if (e1.nom == eq.nom)
                    {
                        existe = true;
                        break;
                    }

                }

                if (existe == false)
                {
                    equipements1.Add(eq);
                    chkEquipements.Items.Add(eq.nom);
                }


            }

            //chkEquipements.Items.AddRange(equipements.ToArray());

            IReadOnlyList<ServiceDiffusion> services = clientService.GetServiceDiffusionByCompteId(numéroCompte);
            IReadOnlyList<Equipement> equipements = clientService.GetEquipementByCompteId(numéroCompte);

            foreach(ServiceDiffusion s in services)
            {
                if (chkServices.Items.Contains(s.nom))
                {
                    chkServices.SetItemChecked(chkServices.Items.IndexOf(s.nom), true);
                }

            }

            foreach(Equipement eq in equipements)
            {
                if (chkEquipements.Items.Contains(eq.nom))
                {
                    chkEquipements.SetItemChecked(chkEquipements.Items.IndexOf(eq.nom), true);
                    
                }
            }

    }
    }
}
