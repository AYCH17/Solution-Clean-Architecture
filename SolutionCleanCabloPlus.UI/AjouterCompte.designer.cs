namespace SolutionCleanCabloPlus.UI
{
    partial class AjouterCompte
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterCompte));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkModeFacturation = new System.Windows.Forms.CheckedListBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.chkServices = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.errVide = new System.Windows.Forms.Label();
            this.chkEquipements = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 585);
            this.panel1.TabIndex = 66;
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
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.DarkBlue;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ajouter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Ajouter.Location = new System.Drawing.Point(560, 488);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(255, 52);
            this.Ajouter.TabIndex = 31;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkModeFacturation);
            this.groupBox3.Location = new System.Drawing.Point(119, 69);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(276, 115);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choix du mode de facturation";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkModeFacturation
            // 
            this.chkModeFacturation.FormattingEnabled = true;
            this.chkModeFacturation.Items.AddRange(new object[] {
            "Mensuel",
            "Annuel"});
            this.chkModeFacturation.Location = new System.Drawing.Point(54, 38);
            this.chkModeFacturation.Name = "chkModeFacturation";
            this.chkModeFacturation.Size = new System.Drawing.Size(153, 61);
            this.chkModeFacturation.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(20, 227);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(129, 16);
            this.label27.TabIndex = 15;
            this.label27.Text = "Choisir les services :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(290, 227);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(153, 16);
            this.label28.TabIndex = 16;
            this.label28.Text = "Choisir les equipements:";
            // 
            // chkServices
            // 
            this.chkServices.FormattingEnabled = true;
            this.chkServices.Location = new System.Drawing.Point(50, 261);
            this.chkServices.Name = "chkServices";
            this.chkServices.Size = new System.Drawing.Size(139, 118);
            this.chkServices.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.errVide);
            this.groupBox4.Controls.Add(this.chkEquipements);
            this.groupBox4.Controls.Add(this.chkServices);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(230, 48);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(586, 419);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informations du compte";
            // 
            // errVide
            // 
            this.errVide.AutoSize = true;
            this.errVide.ForeColor = System.Drawing.Color.DarkRed;
            this.errVide.Location = new System.Drawing.Point(109, 398);
            this.errVide.Name = "errVide";
            this.errVide.Size = new System.Drawing.Size(375, 18);
            this.errVide.TabIndex = 24;
            this.errVide.Text = "*Il faut au moins sélectionner un élément de chaque liste";
            this.errVide.Visible = false;
            // 
            // chkEquipements
            // 
            this.chkEquipements.FormattingEnabled = true;
            this.chkEquipements.Location = new System.Drawing.Point(314, 261);
            this.chkEquipements.Name = "chkEquipements";
            this.chkEquipements.Size = new System.Drawing.Size(192, 118);
            this.chkEquipements.TabIndex = 23;
            // 
            // AjouterCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(933, 577);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AjouterCompte";
            this.Text = "AjouterCompte";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chkModeFacturation;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckedListBox chkServices;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckedListBox chkEquipements;
        private System.Windows.Forms.Label errVide;
    }
}