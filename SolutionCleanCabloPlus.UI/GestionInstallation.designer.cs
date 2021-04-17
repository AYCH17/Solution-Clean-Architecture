namespace SolutionCleanCabloPlus.UI
{
    partial class GestionInstallation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionInstallation));
            this.btnConsulterDisponibles = new System.Windows.Forms.Button();
            this.btnAjoutDate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grdInstallations = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProgrammation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAjoutee = new System.Windows.Forms.DateTimePicker();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstallations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsulterDisponibles
            // 
            this.btnConsulterDisponibles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConsulterDisponibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulterDisponibles.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsulterDisponibles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConsulterDisponibles.Location = new System.Drawing.Point(159, 395);
            this.btnConsulterDisponibles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsulterDisponibles.Name = "btnConsulterDisponibles";
            this.btnConsulterDisponibles.Size = new System.Drawing.Size(284, 45);
            this.btnConsulterDisponibles.TabIndex = 66;
            this.btnConsulterDisponibles.Text = "Consulter les dates disponibles";
            this.btnConsulterDisponibles.UseVisualStyleBackColor = false;
            this.btnConsulterDisponibles.Click += new System.EventHandler(this.btnConsulterDisponibles_Click);
            // 
            // btnAjoutDate
            // 
            this.btnAjoutDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjoutDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutDate.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAjoutDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAjoutDate.Location = new System.Drawing.Point(490, 395);
            this.btnAjoutDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAjoutDate.Name = "btnAjoutDate";
            this.btnAjoutDate.Size = new System.Drawing.Size(284, 45);
            this.btnAjoutDate.TabIndex = 65;
            this.btnAjoutDate.Text = "Ajouter la date";
            this.btnAjoutDate.UseVisualStyleBackColor = false;
            this.btnAjoutDate.Click += new System.EventHandler(this.btnAjoutDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(334, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Installations non programmées";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 585);
            this.panel3.TabIndex = 70;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 7);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 84);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // grdInstallations
            // 
            this.grdInstallations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdInstallations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.compte,
            this.dateProgrammation});
            this.grdInstallations.Location = new System.Drawing.Point(159, 96);
            this.grdInstallations.Name = "grdInstallations";
            this.grdInstallations.RowTemplate.Height = 25;
            this.grdInstallations.Size = new System.Drawing.Size(615, 150);
            this.grdInstallations.TabIndex = 71;
            this.grdInstallations.MultiSelect = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "Numéro";
            this.numero.Name = "numero";
            // 
            // compte
            // 
            this.compte.HeaderText = "Compte";
            this.compte.Name = "compte";
            // 
            // dateProgrammation
            // 
            this.dateProgrammation.HeaderText = "Date de programmation";
            this.dateProgrammation.Name = "dateProgrammation";
            // 
            // dateAjoutee
            // 
            this.dateAjoutee.Location = new System.Drawing.Point(533, 366);
            this.dateAjoutee.Name = "dateAjoutee";
            this.dateAjoutee.Size = new System.Drawing.Size(200, 23);
            this.dateAjoutee.TabIndex = 72;
            // 
            // GestionInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(803, 465);
            this.Controls.Add(this.dateAjoutee);
            this.Controls.Add(this.grdInstallations);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnConsulterDisponibles);
            this.Controls.Add(this.btnAjoutDate);
            this.Controls.Add(this.label5);
            this.Load += new System.EventHandler(this.GestionInstallation_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionInstallation";
            this.Text = "GestionInstallation";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdInstallations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulterDisponibles;
        private System.Windows.Forms.Button btnAjoutDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView grdInstallations;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn compte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProgrammation;
        private System.Windows.Forms.DateTimePicker dateAjoutee;
    }
}