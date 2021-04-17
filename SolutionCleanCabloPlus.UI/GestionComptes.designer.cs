using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SolutionCleanCabloPlus.UI
{
    partial class GestionComptes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void backgroundWorkerFacturation_DoWork(object sender, DoWorkEventArgs e)
        {
            // Do not access the form's BackgroundWorker reference directly.
            // Instead, use the reference provided by the sender parameter.
            BackgroundWorker bw = sender as BackgroundWorker;

            

            // Start the time-consuming operation.
            e.Result = FacturerChaqueJour();

            // If the operation was canceled by the user,
            // set the DoWorkEventArgs.Cancel property to true.
            if (bw.CancellationPending)
            {
                e.Cancel = true;
            }
        }

        private Task FacturerChaqueJour()
        {
            var DailyTime = "01:00:00";
            var timeParts = DailyTime.Split(new char[1] { ':' });

            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day,
                       int.Parse(timeParts[0]), int.Parse(timeParts[1]), int.Parse(timeParts[2]));
            TimeSpan ts;
            if (date > dateNow)
                ts = date - dateNow;
            else
            {
                date = date.AddDays(1);
                ts = date - dateNow;
            }

            //waits certan time and run the code
            return Task.Delay(ts).ContinueWith((x) => facturationService.FacturerComptesAsync());

            
        }
    
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionComptes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChercherClient = new System.Windows.Forms.ComboBox();
            this.cmbChercherCompte = new System.Windows.Forms.ComboBox();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnConsulterClient = new System.Windows.Forms.Button();
            this.btnVoirFilm = new System.Windows.Forms.Button();
            this.btnConsulterFacture = new System.Windows.Forms.Button();
            this.btnSupprimerCompte = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtModeFacture = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSolde = new System.Windows.Forms.TextBox();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.txtNumeroCompte = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnModifierCompte = new System.Windows.Forms.Button();
            this.btnConsulterCompte = new System.Windows.Forms.Button();
            this.btnAjouterCompte = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.errTerritoire = new System.Windows.Forms.Label();
            this.succesTerritoire = new System.Windows.Forms.Label();
            this.cmbTerritoire = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerFacturation = new System.ComponentModel.BackgroundWorker();
            this.grdComptes = new System.Windows.Forms.DataGridView();
            this.solde1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(130, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 580);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdComptes);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmbChercherClient);
            this.tabPage2.Controls.Add(this.cmbChercherCompte);
            this.tabPage2.Controls.Add(this.btnModifierClient);
            this.tabPage2.Controls.Add(this.btnConsulterClient);
            this.tabPage2.Controls.Add(this.btnVoirFilm);
            this.tabPage2.Controls.Add(this.btnConsulterFacture);
            this.tabPage2.Controls.Add(this.btnSupprimerCompte);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnModifierCompte);
            this.tabPage2.Controls.Add(this.btnConsulterCompte);
            this.tabPage2.Controls.Add(this.btnAjouterCompte);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Chercher client par nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chercher compte par numéro";
            // 
            // cmbChercherClient
            // 
            this.cmbChercherClient.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbChercherClient.FormattingEnabled = true;
            this.cmbChercherClient.Location = new System.Drawing.Point(197, 278);
            this.cmbChercherClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbChercherClient.Name = "cmbChercherClient";
            this.cmbChercherClient.Size = new System.Drawing.Size(194, 23);
            this.cmbChercherClient.TabIndex = 32;
            // 
            // cmbChercherCompte
            // 
            this.cmbChercherCompte.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbChercherCompte.FormattingEnabled = true;
            this.cmbChercherCompte.Location = new System.Drawing.Point(670, 29);
            this.cmbChercherCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbChercherCompte.Name = "cmbChercherCompte";
            this.cmbChercherCompte.Size = new System.Drawing.Size(194, 23);
            this.cmbChercherCompte.TabIndex = 31;
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifierClient.Enabled = false;
            this.btnModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModifierClient.Location = new System.Drawing.Point(594, 420);
            this.btnModifierClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(241, 42);
            this.btnModifierClient.TabIndex = 30;
            this.btnModifierClient.Text = "Modifier Client";
            this.btnModifierClient.UseVisualStyleBackColor = false;
            this.btnModifierClient.Click += new System.EventHandler(this.ModifierClient_Click);
            // 
            // btnConsulterClient
            // 
            this.btnConsulterClient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConsulterClient.Enabled = false;
            this.btnConsulterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulterClient.Location = new System.Drawing.Point(594, 372);
            this.btnConsulterClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsulterClient.Name = "btnConsulterClient";
            this.btnConsulterClient.Size = new System.Drawing.Size(241, 42);
            this.btnConsulterClient.TabIndex = 29;
            this.btnConsulterClient.Text = "Consulter Client";
            this.btnConsulterClient.UseVisualStyleBackColor = false;
            this.btnConsulterClient.Click += new System.EventHandler(this.ConsulterClient_Click);
            // 
            // btnVoirFilm
            // 
            this.btnVoirFilm.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVoirFilm.Enabled = false;
            this.btnVoirFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoirFilm.Location = new System.Drawing.Point(301, 100);
            this.btnVoirFilm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoirFilm.Name = "btnVoirFilm";
            this.btnVoirFilm.Size = new System.Drawing.Size(153, 42);
            this.btnVoirFilm.TabIndex = 27;
            this.btnVoirFilm.Text = "Voir un film";
            this.btnVoirFilm.UseVisualStyleBackColor = false;
            this.btnVoirFilm.Click += new System.EventHandler(this.VoirFilm_Click);
            // 
            // btnConsulterFacture
            // 
            this.btnConsulterFacture.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConsulterFacture.Enabled = false;
            this.btnConsulterFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterFacture.Location = new System.Drawing.Point(301, 150);
            this.btnConsulterFacture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsulterFacture.Name = "btnConsulterFacture";
            this.btnConsulterFacture.Size = new System.Drawing.Size(153, 42);
            this.btnConsulterFacture.TabIndex = 26;
            this.btnConsulterFacture.Text = "Consulter la facture";
            this.btnConsulterFacture.UseVisualStyleBackColor = false;
            this.btnConsulterFacture.Click += new System.EventHandler(this.ConsulterFacture_Click);
            // 
            // btnSupprimerCompte
            // 
            this.btnSupprimerCompte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSupprimerCompte.Enabled = false;
            this.btnSupprimerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSupprimerCompte.Location = new System.Drawing.Point(52, 177);
            this.btnSupprimerCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSupprimerCompte.Name = "btnSupprimerCompte";
            this.btnSupprimerCompte.Size = new System.Drawing.Size(241, 42);
            this.btnSupprimerCompte.TabIndex = 25;
            this.btnSupprimerCompte.Text = "Supprimer";
            this.btnSupprimerCompte.UseVisualStyleBackColor = false;
            this.btnSupprimerCompte.Click += new System.EventHandler(this.SupprimerCompte_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtModeFacture);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtSolde);
            this.groupBox4.Controls.Add(this.txtNomClient);
            this.groupBox4.Controls.Add(this.txtNumeroCompte);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(496, 60);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(418, 175);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information sur le compte";
            // 
            // txtModeFacture
            // 
            this.txtModeFacture.Location = new System.Drawing.Point(191, 100);
            this.txtModeFacture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtModeFacture.Name = "txtModeFacture";
            this.txtModeFacture.Size = new System.Drawing.Size(148, 23);
            this.txtModeFacture.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 100);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mode Facture :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 135);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "$";
            // 
            // txtSolde
            // 
            this.txtSolde.Location = new System.Drawing.Point(191, 135);
            this.txtSolde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSolde.Name = "txtSolde";
            this.txtSolde.Size = new System.Drawing.Size(148, 23);
            this.txtSolde.TabIndex = 5;
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(191, 63);
            this.txtNomClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(148, 23);
            this.txtNomClient.TabIndex = 4;
            // 
            // txtNumeroCompte
            // 
            this.txtNumeroCompte.Location = new System.Drawing.Point(191, 25);
            this.txtNumeroCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumeroCompte.Name = "txtNumeroCompte";
            this.txtNumeroCompte.Size = new System.Drawing.Size(148, 23);
            this.txtNumeroCompte.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Solde :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 67);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nom du client :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(47, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Numéro du compte :";
            // 
            // btnModifierCompte
            // 
            this.btnModifierCompte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModifierCompte.Enabled = false;
            this.btnModifierCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModifierCompte.Location = new System.Drawing.Point(52, 127);
            this.btnModifierCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModifierCompte.Name = "btnModifierCompte";
            this.btnModifierCompte.Size = new System.Drawing.Size(241, 42);
            this.btnModifierCompte.TabIndex = 22;
            this.btnModifierCompte.Text = "Modifier Compte";
            this.btnModifierCompte.UseVisualStyleBackColor = false;
            this.btnModifierCompte.Click += new System.EventHandler(this.ModifierCompte_Click);
            // 
            // btnConsulterCompte
            // 
            this.btnConsulterCompte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConsulterCompte.Enabled = false;
            this.btnConsulterCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulterCompte.Location = new System.Drawing.Point(52, 78);
            this.btnConsulterCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsulterCompte.Name = "btnConsulterCompte";
            this.btnConsulterCompte.Size = new System.Drawing.Size(241, 42);
            this.btnConsulterCompte.TabIndex = 21;
            this.btnConsulterCompte.Text = "Consulter Compte";
            this.btnConsulterCompte.UseVisualStyleBackColor = false;
            this.btnConsulterCompte.Click += new System.EventHandler(this.ConsulterCompte_Click);
            // 
            // btnAjouterCompte
            // 
            this.btnAjouterCompte.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouterCompte.Enabled = false;
            this.btnAjouterCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterCompte.Location = new System.Drawing.Point(594, 323);
            this.btnAjouterCompte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjouterCompte.Name = "btnAjouterCompte";
            this.btnAjouterCompte.Size = new System.Drawing.Size(241, 42);
            this.btnAjouterCompte.TabIndex = 19;
            this.btnAjouterCompte.Text = "Ajouter Compte";
            this.btnAjouterCompte.UseVisualStyleBackColor = false;
            this.btnAjouterCompte.Click += new System.EventHandler(this.AjouterCompte_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.btnAjouterClient);
            this.tabPage3.Controls.Add(this.errTerritoire);
            this.tabPage3.Controls.Add(this.succesTerritoire);
            this.tabPage3.Controls.Add(this.cmbTerritoire);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Size = new System.Drawing.Size(1082, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Tag = "";
            this.tabPage3.Text = "Vérification du territoire";
            this.tabPage3.ToolTipText = "Choisir le territoire";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAjouterClient.Location = new System.Drawing.Point(632, 399);
            this.btnAjouterClient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(241, 42);
            this.btnAjouterClient.TabIndex = 29;
            this.btnAjouterClient.Text = "Ajouter Client";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            // 
            // errTerritoire
            // 
            this.errTerritoire.AutoSize = true;
            this.errTerritoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errTerritoire.ForeColor = System.Drawing.Color.Red;
            this.errTerritoire.Location = new System.Drawing.Point(217, 297);
            this.errTerritoire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errTerritoire.Name = "errTerritoire";
            this.errTerritoire.Size = new System.Drawing.Size(202, 20);
            this.errTerritoire.TabIndex = 22;
            this.errTerritoire.Text = "Territoire NON Desservi!";
            this.errTerritoire.Visible = false;
            // 
            // succesTerritoire
            // 
            this.succesTerritoire.AutoSize = true;
            this.succesTerritoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.succesTerritoire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.succesTerritoire.Location = new System.Drawing.Point(235, 253);
            this.succesTerritoire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.succesTerritoire.Name = "succesTerritoire";
            this.succesTerritoire.Size = new System.Drawing.Size(160, 20);
            this.succesTerritoire.TabIndex = 21;
            this.succesTerritoire.Text = "Territoire Desservi!";
            this.succesTerritoire.Visible = false;
            // 
            // cmbTerritoire
            // 
            this.cmbTerritoire.FormattingEnabled = true;
            this.cmbTerritoire.Items.AddRange(new object[] {
            "Alberta",
            "Colombie-Britannique",
            "Île-du-Prince-Édouard",
            "Manitoba",
            "Nouveau-Brunswick",
            "Nouvelle-Écosse",
            "Nunavut",
            "Ontario",
            "Québec",
            "Saskatchewan",
            "Terre-Neuve-et-Labrador",
            "Territoires du Nord-Ouest",
            "Yukon"});
            this.cmbTerritoire.Location = new System.Drawing.Point(170, 143);
            this.cmbTerritoire.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbTerritoire.Name = "cmbTerritoire";
            this.cmbTerritoire.Size = new System.Drawing.Size(274, 23);
            this.cmbTerritoire.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(167, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Territoire :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(-4, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 643);
            this.panel2.TabIndex = 46;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 84);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // backgroundWorkerFacturation
            // 
            this.backgroundWorkerFacturation.WorkerSupportsCancellation = true;
            this.backgroundWorkerFacturation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerFacturation_DoWork);
            // 
            // grdComptes
            // 
            this.grdComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdComptes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numéro,
            this.solde1});
            this.grdComptes.Location = new System.Drawing.Point(102, 323);
            this.grdComptes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grdComptes.MultiSelect = false;
            this.grdComptes.Name = "grdComptes";
            this.grdComptes.Size = new System.Drawing.Size(289, 122);
            this.grdComptes.TabIndex = 35;
            // 
            // solde1
            // 
            this.solde1.HeaderText = "solde";
            this.solde1.Name = "solde1";
            // 
            // numéro
            // 
            this.numéro.HeaderText = "numéro";
            this.numéro.Name = "numéro";
            // 
            // GestionComptes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1083, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionComptes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des comptes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdComptes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnConsulterClient;
        private System.Windows.Forms.Button btnVoirFilm;
        private System.Windows.Forms.Button btnConsulterFacture;
        private System.Windows.Forms.Button btnSupprimerCompte;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtModeFacture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSolde;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.TextBox txtNumeroCompte;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnModifierCompte;
        private System.Windows.Forms.Button btnConsulterCompte;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label errTerritoire;
        private System.Windows.Forms.Label succesTerritoire;
        private System.Windows.Forms.ComboBox cmbTerritoire;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChercherClient;
        private System.Windows.Forms.ComboBox cmbChercherCompte;
        private System.Windows.Forms.Button btnAjouterCompte;
        private System.Windows.Forms.Button btnAjouterClient;
        private BackgroundWorker backgroundWorkerFacturation;
        private System.Windows.Forms.DataGridView grdComptes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn solde1;
    }
}