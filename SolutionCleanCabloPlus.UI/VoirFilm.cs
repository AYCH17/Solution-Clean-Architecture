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
    public partial class VoirFilm : Form
    {
        int numéroCompte;
        IClientService clientService;

        public VoirFilm(int numéroCompte, IClientService clientService)
        {
            this.numéroCompte = numéroCompte;
            this.clientService = clientService;
            InitializeComponent();
        }

        private void CmbTitre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Film film = clientService.GetFilmByNom(cmbTitre.SelectedItem.ToString())[0];
            txtMontantLocation.Text = film.montantLocation.ToString();
        }

        private void VoirFilm_Load(object sender, EventArgs e)
        {
            txtNumero.Text = numéroCompte.ToString();
            IReadOnlyList<Film>  films = clientService.GetAllFilms();
            foreach(Film f in films)
            {
                cmbTitre.Items.Add(f.titre);
            }

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string nomFilm = cmbTitre.SelectedItem.ToString();
            clientService.AddLoueFilm(new LoueFilm(DateTime.Now, clientService.GetCompteById(numéroCompte), clientService.GetFilmByNom(nomFilm)[0]));
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
